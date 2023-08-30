using System;
using CapaEntidades;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Collections.Generic;
namespace CapaAccesoDatos
{
    public class DAPacientes
    {
        // atributos
        private string _cadenaConexion;
        private string _mensaje;

        public string Mensaje
        {
            get => _mensaje;
        }// MENSAJE

        public DAPacientes(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }// CONEXION

        public int insertar(EntidadPacientes pacientes)
        {
            // establecer el objeto de conexion
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            // establecer el objetp [ara ejecutar comandos sql
            SqlCommand comando = new SqlCommand();
            // devolver valor guardado
            int id = 0;

            string sentencia = "INSERT INTO PACIENTES(CEDULA_PACIENTE,NOMBRE_COMPLETO_PACIENTE,TELEFONO_PACIENTE,CORREO_PACIENTE, DIRECCION_PACIENTE) VALUES(@CEDULA_PACIENTE,@NOMBRE_COMPLETO_PACIENTE,@TELEFONO_PACIENTE,@CORREO_PACIENTE, @DIRECCION_PACIENTE) select  @@identity";
            // pasar la conexion  al command
            comando.Connection = conexion;
            // especificar las variables
            comando.Parameters.AddWithValue("@CEDULA_PACIENTE", pacientes.getCedulaPaciente());
            comando.Parameters.AddWithValue("@NOMBRE_COMPLETO_PACIENTE", pacientes.getNombrePaciente());
            comando.Parameters.AddWithValue("@TELEFONO_PACIENTE", pacientes.getTelefonoPaciente());
            comando.Parameters.AddWithValue("@CORREO_PACIENTE", pacientes.getCorreoPaciente());
            comando.Parameters.AddWithValue("@DIRECCION_PACIENTE", pacientes.getDireccionPacientes());
            comando.CommandText = sentencia;
            // ejecutar el comando
            try
            {
                conexion.Open();
                id = Convert.ToInt32(comando.ExecuteScalar());
                conexion.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Dispose();
                comando.Dispose();
            }
            return id;
        }// fin metodo insertar


        // LISTAR PACIENTE

        public DataSet ListarPacientes(string condicion, string orden)
        {
            DataSet datos = new DataSet();// se guarda en la tagla de copnsultaas sql
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            string sentencia = "SELECT ID_PACIENTE, CEDULA_PACIENTE, NOMBRE_COMPLETO_PACIENTE,TELEFONO_PACIENTE, CORREO_PACIENTE, DIRECCION_PACIENTE FROM PACIENTES";

            if (!string.IsNullOrEmpty(condicion))
            {
                sentencia = string.Format("{0} where {1}", sentencia, condicion);
            }
            if (!string.IsNullOrEmpty(orden))
            {
                sentencia = string.Format("{0} where {1}", sentencia, condicion);
            }
            try
            {// se prepara adapter
                adapter = new SqlDataAdapter(sentencia, conexion);
                // se ejecuta adapter
                adapter.Fill(datos, "Pacientes");
            }
            catch (Exception)
            {

                throw;
            }
            return datos;
        }//LISTAR CLIENTES


        public int EliminarRegistroConSP(EntidadPacientes paciente)
        { //eliminar registro con Stored Procedure
            int resultado = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "ELIMINAR"; //nombre del procedimiento almacenado
            //se especifica que tipo de comando es, en este caso es un procedimiento almacenado
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion;
            //parametro de entrada para el SP
            comando.Parameters.AddWithValue("@idPaciente", paciente.IdPaciente);
            //parametro de salida del SP
            comando.Parameters.Add("@msj", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;
            //se declara otro parametro de retorno del SP que obtenga el retorno del SP
            comando.Parameters.Add("@retorno", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery(); //ejecuta el SP y se llenan las variables de retorno del SP
                resultado = Convert.ToInt32(comando.Parameters["@retorno"].Value); //obtengo la variable de retorno
                //se va a leer el parametro de salida del SP
                _mensaje = comando.Parameters["@msj"].Value.ToString();//obtiene el mensaje que se devolvio del SP
                conexion.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return resultado;
        }//EliminarRegistroConSP



        // metodo eliminar
        public int EliminarPaciente(EntidadPacientes pacientes)
        {
            int afectado =-1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            string sentencia = "DELETE FROM PACIENTES";
            sentencia = string.Format("{0} WHERE ID_PACIENTE ={1}", sentencia, pacientes.IdPaciente);
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                afectado = comando.ExecuteNonQuery();

                conexion.Close();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Dispose();
                comando.Dispose();
            }
            return afectado;
        }// fin clase elminar cliente

        public bool existeEntidad(string cedulaPaciente)
        {
            bool existe = false;
            
            try
            {
                using (SqlConnection conexion = new SqlConnection(_cadenaConexion))
                {
                    conexion.Open();

                    using (SqlCommand comando = new SqlCommand())
                    {
                        comando.Connection = conexion;
                        comando.CommandText = "SELECT COUNT(*) FROM PACIENTES WHERE CEDULA_PACIENTE = @CEDULA_PACIENTE";
                        comando.Parameters.AddWithValue("@CEDULA_PACIENTE", cedulaPaciente);

                        // Ejecutar la consulta y obtener el resultado.
                        int count = (int)comando.ExecuteScalar();

                        // Si count es mayor que cero, significa que existe un funcionario con el ID proporcionado.
                        if (count > 0)
                        {
                            existe = true;
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            return existe;
        }


        // obtener pacintes
        public EntidadPacientes obtenerPaciente(int id)
        {
            EntidadPacientes pacientes = null;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            SqlDataReader dataReader;// no tiene constructor se lleva con excute
            string sentencia = string.Format("SELECT  ID_PACIENTE, CEDULA_PACIENTE, NOMBRE_COMPLETO_PACIENTE,TELEFONO_PACIENTE, CORREO_PACIENTE,  DIRECCION_PACIENTE FROM PACIENTES WHERE ID_PACIENTE= {0} ", id );
            // si el id es texto entonces se escvribe en tre comillas ("")
            comando.Connection = conexion;
            comando.CommandText = sentencia;
            try
            {
                conexion.Open();
                dataReader = comando.ExecuteReader();
                if (dataReader.HasRows)
                {
                    pacientes = new EntidadPacientes();
                    dataReader.Read();// lee fila por fila del datareadear
                    pacientes.IdPaciente = dataReader.GetInt32(0);
                    pacientes.CedulaPaciente = dataReader.GetString(1);
                    pacientes.NombrePaciente = dataReader.GetString(2);
                    pacientes.TelefonoPaciente = dataReader.GetInt32(3);
                    pacientes.CorrreoPaciente = dataReader.GetString(4);
                    pacientes.DireccionPacientes = dataReader.GetString(5);
                    pacientes.Existe = true;
                }
                conexion.Close();
            }
            catch (Exception)
            {

                throw;
            }
            return pacientes;
        }// obtener pacienetes

        //
        public int modificarPacientes(EntidadPacientes pacientes)
        {
            int filasAfectadas = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            string sentencia = "UPDATE PACIENTES SET CEDULA_PACIENTE = @CEDULA_PACIENTE, NOMBRE_COMPLETO_PACIENTE= @NOMBRE_COMPLETO_PACIENTE, TELEFONO_PACIENTE= @TELEFONO_PACIENTE, CORREO_PACIENTE= @CORREO_PACIENTE,DIRECCION_PACIENTE= @DIRECCION_PACIENTE WHERE ID_PACIENTE= @ID_PACIENTE";
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@ID_PACIENTE", pacientes.IdPaciente);
            comando.Parameters.AddWithValue("@CEDULA_PACIENTE", pacientes.CedulaPaciente);
            comando.Parameters.AddWithValue("@NOMBRE_COMPLETO_PACIENTE", pacientes.NombrePaciente);
            comando.Parameters.AddWithValue("@TELEFONO_PACIENTE", pacientes.TelefonoPaciente);
            comando.Parameters.AddWithValue("@CORREO_PACIENTE", pacientes.CorrreoPaciente);
            comando.Parameters.AddWithValue("@DIRECCION_PACIENTE", pacientes.TelefonoPaciente);

            try
            {
                conexion.Open();
                filasAfectadas = comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Dispose();
                comando.Dispose();
            }
            return filasAfectadas;
        }



    }// fin Class DAPacientes
}// fin namespace
