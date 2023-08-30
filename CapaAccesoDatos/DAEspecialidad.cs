using System;
using CapaEntidades;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Collections.Generic;

namespace CapaAccesoDatos
{
   public  class DAEspecialidad
    {
        private string _cadenaConexion;
        private string _mensaje;


        public string Mensaje
        {
            get => _mensaje;
        }

        public DAEspecialidad(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        public int Insertar(EntidadEspecialidad especialidad)
        {
            //Establecer el objeto de conexion
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            //establecer el objeto para ejecutar comandos de sql
            SqlCommand comando = new SqlCommand();
            //devolver valor guardado 
            int id = 0;
            string sentencia = "INSERT INTO ESPECIALIDADES (NOMBRE_ESPECIALIDAD, DESCRIPCION_ESPECIALIDAD ) VALUES(@NOMBRE_ESPECIALIDAD, @DESCRIPCION_ESPECIALIDAD) select @@identity";

            //Pasar la coneccion al command 
            comando.Connection = conexion;
            //Especificar variables
            comando.Parameters.AddWithValue("@NOMBRE_ESPECIALIDAD", especialidad.getNombre_Especialidad());
            comando.Parameters.AddWithValue("@DESCRIPCION_ESPECIALIDAD", especialidad.getDescripcion_Especialidad());
       
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
        public DataSet ListarEspecialidad(string condicion, string orden)
        {
            DataSet datos = new DataSet();//Se guarda la tabla de la consulta de SQL
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            string sentencia = "SELECT ID_ESPECIALIDAD, NOMBRE_ESPECIALIDAD, DESCRIPCION_ESPECIALIDAD FROM ESPECIALIDADES";

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
                adapter.Fill(datos, "Especialidades");
            }
            catch (Exception)
            {
                throw;
            }

            return datos;
        }

        
       

        //Metodo recibe el ID del ciente y devuelve la entidad cliente

        public EntidadEspecialidad obtenerEspecialidad(int id)
        {
            EntidadEspecialidad especialidad = null;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            SqlDataReader dataReader; //No tiene constructor, se llena con el execute
            string sentencia = string.Format("SELECT ID_ESPECIALIDAD, NOMBRE_ESPECIALIDAD, DESCRIPCION_ESPECIALIDAD FROM ESPECIALIDADES WHERE ID_ESPECIALIDAD = {0}", id);

            //Si el id es texto se escribe entre comillas 
            comando.Connection = conexion;
            comando.CommandText = sentencia;

            try
            {
                conexion.Open();
                dataReader = comando.ExecuteReader();
                if (dataReader.HasRows)
                {
                    especialidad = new EntidadEspecialidad();
                    dataReader.Read(); //Lee fila or fila del dataReader
                    especialidad.Id_Especialidad = dataReader.GetInt32(0);
                    especialidad.Nombre_Especialidad = dataReader.GetString(1);
                    especialidad.Descripcion_Especialidad = dataReader.GetString(2);

                    especialidad.Existe = true;
                }
                conexion.Close();
            }
            catch (Exception)
            {

                throw;
            }
            return especialidad;
        }


        //Eliminar sin SP
        public int EliminarEspecialidad(EntidadEspecialidad especialidad)
        {
            int afectado = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            string sentencia = "DELETE FROM ESPECIALIDADES";
            sentencia = string.Format("{0} WHERE ID_ESPECIALIDAD = {1}", sentencia, especialidad.Id_Especialidad);
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

        public int modificarEspecialidad(EntidadEspecialidad especialidad)
        {
            int filasAfectadas = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            string sentencia = "UPDATE ESPECIALIDADAS SET NOMBRE_ESPECIALIDAD= @NOMBRE_ESPECIALIDAD, DESCRIPCION_ESPECIALIDAD= @DESCRIPCION_ESPECIALIDAD WHERE ID_ESPECIALIDAD= @ID_ESPECIALIDAD";
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@ID_ESPECIALIDAD", especialidad.Id_Especialidad);
            comando.Parameters.AddWithValue("@NOMBRE_ESPECIALIDAD", especialidad.Nombre_Especialidad);
            comando.Parameters.AddWithValue("@DESCRIPCION_ESPECIALIDAD", especialidad.Descripcion_Especialidad);

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


    }// fin Daespecialidad
}// fin namespace
