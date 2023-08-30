using System;
using CapaEntidades;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Collections.Generic;


namespace CapaAccesoDatos
{
    public class DAEspecialistas
    {

        private string _cadenaConexion;
        private string _mensaje;


        public string Mensaje
        {
            get => _mensaje;
        }

        public DAEspecialistas(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        public int Insertar(EntidadEspecialistas Especialista)
        {
            //Establecer el objeto de conexion
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            //establecer el objeto para ejecutar comandos de sql
            SqlCommand comando = new SqlCommand();
            //devolver valor guardado 
            int id = 0;
            string sentencia = "INSERT INTO ESPECIALISTAS (NOMBRE_COMPLETO_ESPECIALISTA, TELEFONO_ESPECIALISTA, CORREO_ESPECIALISTA,DIRECCION_ESPECIALISTA) VALUES(@NOMBRE_COMPLETO_ESPECIALISTA, @TELEFONO_ESPECIALISTA, @CORREO_ESPECIALISTA,@DIRECCION_ESPECIALISTA) select @@identity";

            //Pasar la coneccion al command 
            comando.Connection = conexion;
            //Especificar variables
            comando.Parameters.AddWithValue("@NOMBRE_COMPLETO_ESPECIALISTA", Especialista.getNombre_Especialista());
            comando.Parameters.AddWithValue("@TELEFONO_ESPECIALISTA", Especialista.getTelefono_Especialista());
            comando.Parameters.AddWithValue("@CORREO_ESPECIALISTA", Especialista.getCorro_Especialista());
            comando.Parameters.AddWithValue("@DIRECCION_ESPECIALISTA", Especialista.getDireccion_Especialista());

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
        public DataSet ListarEspecialistas(string condicion, string orden)
        {
            DataSet datos = new DataSet();//Se guarda la tabla de la consulta de SQL
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            string sentencia = "Select ID_ESPECIALISTA, NOMBRE_COMPLETO_ESPECIALISTA, TELEFONO_ESPECIALISTA, CORREO_ESPECIALISTA, DIRECCION_ESPECIALISTA from ESPECIALISTAS";

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
                adapter.Fill(datos, "Especialistas");
            }
            catch (Exception)
            {
                throw;
            }

            return datos;
        }

       

        //Metodo recibe el ID del ciente y devuelve la entidad cliente

        public EntidadEspecialistas obtenerEspecialista(int id)
        {
            EntidadEspecialistas Especialista = null;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            SqlDataReader dataReader; //No tiene constructor, se llena con el execute
            string sentencia = string.Format("SELECT ID_ESPECIALISTA, NOMBRE_COMPLETO_ESPECIALISTA, TELEFONO_ESPECIALISTA, CORREO_ESPECIALISTA, DIRECCION_ESPECIALISTA FROM ESPECIALISTAS WHERE ID_ESPECIALISTA = {0}", id);

            //Si el id es texto se escribe entre comillas 
            comando.Connection = conexion;
            comando.CommandText = sentencia;

            try
            {
                conexion.Open();
                dataReader = comando.ExecuteReader();
                if (dataReader.HasRows)
                {
                    Especialista = new EntidadEspecialistas();
                    dataReader.Read(); //Lee fila or fila del dataReader
                    Especialista.Id_Especialista = dataReader.GetInt32(0);
                    Especialista.Nombre_Especialista = dataReader.GetString(1);
                    Especialista.Telefono_Especialista = dataReader.GetInt32(2);
                    Especialista.Corro_Especialista = dataReader.GetString(3);
                    Especialista.Direccion_Especialista = dataReader.GetString(4);
                    Especialista.Existe = true;
                }
                conexion.Close();
            }
            catch (Exception)
            {

                throw;
            }
            return Especialista;
        }

      

        //Eliminar sin SP
        public int EliminarEspecialista(EntidadEspecialistas Especialista)
        {
            int afectado = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            string sentencia = "DELETE FROM ESPECIALISTAS";
            sentencia = string.Format("{0} WHERE ID_ESPECIALISTA = {1}", sentencia, Especialista.Id_Especialista);
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

        public int modificarEspecialista(EntidadEspecialistas Especialista)
        {
            int filasAfectadas = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            string sentencia = "UPDATE ESPECIALISTAS SET NOMBRE_COMPLETO_ESPECIALISTA= @NOMBRE_COMPLETO_ESPECIALISTA, TELEFONO_ESPECIALISTA= @TELEFONO_ESPECIALISTA, CORREO_ESPECIALISTA= @CORREO_ESPECIALISTA, DIRECCION_ESPECIALISTA=@DIRECCION_ESPECIALISTA  WHERE ID_ESPECIALISTA= @ID_ESPECIALISTA";
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@ID_ESPECIALISTA", Especialista.Id_Especialista);
            comando.Parameters.AddWithValue("@NOMBRE_COMPLETO_ESPECIALISTA", Especialista.Nombre_Especialista);
            comando.Parameters.AddWithValue("@TELEFONO_ESPECIALISTA", Especialista.Telefono_Especialista);
            comando.Parameters.AddWithValue("@CORREO_ESPECIALISTA", Especialista.Corro_Especialista);
            comando.Parameters.AddWithValue("@DIRECCION_ESPECIALISTA", Especialista.Direccion_Especialista);

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



    }// FIN DAEspecialistas
}// fin namesspace
