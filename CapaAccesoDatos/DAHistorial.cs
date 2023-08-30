using System;
using CapaEntidades;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Collections.Generic;

namespace CapaAccesoDatos
{
    public class DAHistorial
    {

        private string _cadenaConexion;
        private string _mensaje;


        public string Mensaje
        {
            get => _mensaje;
        }

        public DAHistorial(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        public int Insertar(EntidadHistorial historial)
        {
            //Establecer el objeto de conexion
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            //establecer el objeto para ejecutar comandos de sql
            SqlCommand comando = new SqlCommand();
            //devolver valor guardado 
            int id = 0;
            string sentencia = "INSERT INTO HISTORIAL_CLINICOS (ID_PACIENTE, ID_MEDICAMENTO, ID_DIAGNOSTICO) VALUES(@ID_PACIENTE, @ID_MEDICAMENTO, @ID_DIAGNOSTICO) select @@identity";

            //Pasar la coneccion al command 
            comando.Connection = conexion;
            //Especificar variables
            comando.Parameters.AddWithValue("@ID_PACIENTE", historial.getIdPaciente());
            comando.Parameters.AddWithValue("@ID_MEDICAMENTO", historial.getIdMedicamento());
            comando.Parameters.AddWithValue("@ID_DIAGNOSTICO", historial.getIdDiagnostico());
            comando.CommandText = sentencia;
            //Ejecutar el comando 
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
        }

        //Devuelve un DataSet de clientes para mostrar en un diagrama
        public DataSet ListarHistorial(string condicion, string orden)
        {
            DataSet datos = new DataSet();//Se guarda la tabla de la consulta de SQL
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            string sentencia = "Select ID_HISTORIAL_CLINICO, ID_PACIENTE, ID_MEDICAMENTO, ID_DIAGNOSTICO from HISTORIAL_CLINICOS";

            if (!string.IsNullOrEmpty(condicion))
            {
                sentencia = string.Format("{0} where {1}", sentencia, condicion);
            }

            if (!string.IsNullOrEmpty(orden))
            {
                sentencia = string.Format("{0} where {1}", sentencia, orden);
            }
            try
            {
                //Se prepara adapter 
                adapter = new SqlDataAdapter(sentencia, conexion);
                //ejecutar sentencia
                adapter.Fill(datos, "Historial");
            }
            catch (Exception)
            {
                throw;
            }

            return datos;
        }

       

        //Metodo recibe el ID del ciente y devuelve la entidad cliente

        public EntidadHistorial obtenerHistorial(int id)
        {
            EntidadHistorial historial = null;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            SqlDataReader dataReader; //No tiene constructor, se llena con el execute
            string sentencia = string.Format("SELECT ID_PACIENTE, ID_MEDICAMENTO, ID_DIAGNOSTICO  WHERE ID_HISTORIAL_CLINICO = {0}", id);

            //Si el id es texto se escribe entre comillas 
            comando.Connection = conexion;
            comando.CommandText = sentencia;

            try
            {
                conexion.Open();
                dataReader = comando.ExecuteReader();
                if (dataReader.HasRows)
                {
                    historial = new EntidadHistorial();
                    dataReader.Read(); //Lee fila or fila del dataReader
                    historial.IdHistorial = dataReader.GetInt32(0);
                    historial.IdPaciente = dataReader.GetInt32(1);
                    historial.IdMedicamento = dataReader.GetInt32(2);
                    historial.IdDiagnosticoe = dataReader.GetInt32(3);
                    historial.Existe = true;
                }
                conexion.Close();
            }
            catch (Exception)
            {

                throw;
            }
            return historial;
        }

      

        //Eliminar sin SP
        public int EliminarHistorial(EntidadHistorial historial)
        {
            int afectado = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            string sentencia = "DELETE FROM HISTORIAL_CLINICOS";
            sentencia = string.Format("{0} WHERE ID_HISTORIAL_CLINICO = {1}", sentencia, historial.IdHistorial);
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
        }

        public int modificarHistorial(EntidadHistorial historial)
        {
            int filasAfectadas = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            string sentencia = "UPDATE HISTORIAL_CLINICOS  SET ID_PACIENTE= @ID_PACIENTE, ID_MEDICAMENTO= @ID_MEDICAMENTO, ID_DIAGNOSTICO= @ID_DIAGNOSTICO WHERE ID_HISTORIAL_CLINICO= @ID_HISTORIAL_CLINICO";
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@ID_PACIENTE", historial.IdPaciente);
            comando.Parameters.AddWithValue("@ID_MEDICAMENTO", historial.IdMedicamento);
            comando.Parameters.AddWithValue("@ID_DIAGNOSTICO", historial.IdDiagnosticoe);

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

    }// fin dahistorial
}// fin nnamespace
