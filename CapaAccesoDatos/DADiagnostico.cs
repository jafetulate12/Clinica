using System;
using CapaEntidades;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Collections.Generic;

namespace CapaAccesoDatos
{
    public class DADiagnostico
    {
        private string _cadenaConexion;
        private string _mensaje;


        public string Mensaje
        {
            get => _mensaje;
        }

        public DADiagnostico(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        public int Insertar(EntidadDiagnostico Diagnostico)
        {
            //Establecer el objeto de conexion
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            //establecer el objeto para ejecutar comandos de sql
            SqlCommand comando = new SqlCommand();
            //devolver valor guardado 
            int id = 0;
            string sentencia = "INSERT INTO DIAGNOSTICOS (ID_ESPECIALISTA, FECHA_DIAGNOSTICO, RESULTADOS_DIAGNOSTICO) VALUES(@ID_ESPECIALISTA, @FECHA_DIAGNOSTICO, @RESULTADOS_DIAGNOSTICO) select @@identity";

            //Pasar la coneccion al command 
            comando.Connection = conexion;
            //Especificar variables
            comando.Parameters.AddWithValue("@ID_ESPECIALISTA", Diagnostico.getId_Especialista());
            comando.Parameters.AddWithValue("@FECHA_DIAGNOSTICO", Diagnostico.getFecha_Diagnostico());
            comando.Parameters.AddWithValue("@RESULTADOS_DIAGNOSTICO", Diagnostico.getResultados_Diagnostico());
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
        public DataSet ListarDiagnostico(string condicion, string orden)
        {
            DataSet datos = new DataSet();//Se guarda la tabla de la consulta de SQL
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            string sentencia = "Select ID_DIAGNOSTICO, ID_ESPECIALISTA, FECHA_DIAGNOSTICO, RESULTADOS_DIAGNOSTICO from DIAGNOSTICOS";

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
                adapter.Fill(datos, "Diagnosticos");
            }
            catch (Exception)
            {
                throw;
            }

            return datos;
        }

    
        //Metodo recibe el ID del ciente y devuelve la entidad cliente

        public EntidadDiagnostico obtenerDiagnostico(int id)
        {
            EntidadDiagnostico diagnostico = null;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            SqlDataReader dataReader; //No tiene constructor, se llena con el execute
            string sentencia = string.Format("SELECT ID_DIAGNOSTICO, ID_ESPECIALISTA, FECHA_DIAGNOSTICO, RESULTADOS_DIAGNOSTICO FROM DIAGNOSTICOS WHERE ID_DIAGNOSTICO = {0}", id);

            //Si el id es texto se escribe entre comillas 
            comando.Connection = conexion;
            comando.CommandText = sentencia;

            try
            {
                conexion.Open();
                dataReader = comando.ExecuteReader();
                if (dataReader.HasRows)
                {
                    diagnostico = new EntidadDiagnostico();
                    dataReader.Read(); //Lee fila or fila del dataReader
                    diagnostico.Id_Diagnostico = dataReader.GetInt32(0);
                    diagnostico.Id_Especialista = dataReader.GetInt32(1);
                    diagnostico.Fecha_Diagnostico = dataReader.GetDateTime(2);
                    diagnostico.Resultados_Diagnostico = dataReader.GetString(3);
                    diagnostico.Existe = true;
                }
                conexion.Close();
            }
            catch (Exception)
            {

                throw;
            }
            return diagnostico;
        }

     
        //Eliminar sin SP
        public int EliminarDiagnostico(EntidadDiagnostico Diagnostico)
        {
            int afectado = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            string sentencia = "DELETE FROM DIAGNOSTICOS";
            sentencia = string.Format("{0} WHERE ID_DIAGNOSTICO = {1}", sentencia, Diagnostico.Id_Diagnostico);
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

        public int modificarDiagnostico(EntidadDiagnostico Diagnostico)
        {
            int filasAfectadas = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            string sentencia = "UPDATE DIAGNOSTICOS SET ID_ESPECIALISTA= @ID_ESPECIALISTA, FECHA_DIAGNOSTICO= @FECHA_DIAGNOSTICO, RESULTADOS_DIAGNOSTICO= @RESULTADOS_DIAGNOSTICO WHERE ID_DIAGNOSTICO= @ID_DIAGNOSTICO";
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@ID_DIAGNOSTICO", Diagnostico.Id_Diagnostico);
            comando.Parameters.AddWithValue("@ID_ESPECIALISTA", Diagnostico.Id_Especialista);
            comando.Parameters.AddWithValue("@FECHA_DIAGNOSTICO", Diagnostico.Fecha_Diagnostico);
            comando.Parameters.AddWithValue("@RESULTADOS_DIAGNOSTICO", Diagnostico.Resultados_Diagnostico);

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









    }// fin dadiagnostico
}//fin namespace
