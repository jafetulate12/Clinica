using System;
using CapaEntidades;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Collections.Generic;

namespace CapaAccesoDatos
{
   public class DAMedicamentos
    {
        private string _cadenaConexion;
        private string _mensaje;


        public string Mensaje
        {
            get => _mensaje;
        }

        public DAMedicamentos(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        public int Insertar(EntidadMedicamentos Medicamento)
        {
            //Establecer el objeto de conexion
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            //establecer el objeto para ejecutar comandos de sql
            SqlCommand comando = new SqlCommand();
            //devolver valor guardado 
            int id = 0;
            string sentencia = "INSERT INTO MEDICAMENTOS (NOMBRE_MEDICAMENTO, DESCRIPCION, INDICACIONES_USO) VALUES(@NOMBRE_MEDICAMENTO, @DESCRIPCION, @INDICACIONES_USO) select @@identity";

            //Pasar la coneccion al command 
            comando.Connection = conexion;
            //Especificar variables
            comando.Parameters.AddWithValue("@NOMBRE_MEDICAMENTO", Medicamento.getNombreMedicamento());
            comando.Parameters.AddWithValue("@DESCRIPCION", Medicamento.getDescripcion());
            comando.Parameters.AddWithValue("@INDICACIONES_USO", Medicamento.getIndicacionesUso());
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
        public DataSet ListarMedicamentos(string condicion, string orden)
        {
            DataSet datos = new DataSet();//Se guarda la tabla de la consulta de SQL
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            string sentencia = "Select ID_MEDICAMENTO, NOMBRE_MEDICAMENTO, DESCRIPCION, INDICACIONES_USO from MEDICAMENTOS";

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
                adapter.Fill(datos, "Medicamentos");
            }
            catch (Exception)
            {
                throw;
            }

            return datos;
        }

        

        //Metodo recibe el ID del ciente y devuelve la entidad cliente

        public EntidadMedicamentos obtenerMedicamento(int id)
        {
            EntidadMedicamentos Medicamentos = null;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            SqlDataReader dataReader; //No tiene constructor, se llena con el execute
            string sentencia = string.Format("SELECT  ID_MEDICAMENTO, NOMBRE_MEDICAMENTO, DESCRIPCION, INDICACIONES_USO FROM MEDICAMENTOS WHERE ID_MEDICAMENTO = {0}", id);

            //Si el id es texto se escribe entre comillas 
            comando.Connection = conexion;
            comando.CommandText = sentencia;

            try
            {
                conexion.Open();
                dataReader = comando.ExecuteReader();
                if (dataReader.HasRows)
                {
                    Medicamentos = new EntidadMedicamentos();
                    dataReader.Read(); //Lee fila or fila del dataReader
                    Medicamentos.IdMedicamento = dataReader.GetInt32(0);
                    Medicamentos.NombreMedicamento = dataReader.GetString(1);
                    Medicamentos.Descripcion = dataReader.GetString(2);
                    Medicamentos.IndicacionesUso = dataReader.GetString(3);
                    Medicamentos.Existe= true;
                }
                conexion.Close();
            }
            catch (Exception)
            {

                throw;
            }
            return Medicamentos;
        }

       

        //Eliminar sin SP
        public int EliminarMedicamento(EntidadMedicamentos Medicamento)
        {
            int afectado = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            string sentencia = "DELETE FROM MEDICAMENTOS";
            sentencia = string.Format("{0} WHERE ID_MEDICAMENTO = {1}", sentencia, Medicamento.IdMedicamento);
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

        public int modificarMedicamento(EntidadMedicamentos Medicamento)
        {
            int filasAfectadas = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            string sentencia = "UPDATE MEDICAMENTOS SET NOMBRE_MEDICAMENTO= @NOMBRE_MEDICAMENTO, DESCRIPCION= @DESCRIPCION, INDICACIONES_USO= @INDICACIONES_USO WHERE ID_MEDICAMENTO= @ID_MEDICAMENTO";
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@ID_MEDICAMENTO", Medicamento.IdMedicamento);
            comando.Parameters.AddWithValue("@NOMBRE_MEDICAMENTO", Medicamento.NombreMedicamento);
            comando.Parameters.AddWithValue("@DESCRIPCION", Medicamento.Descripcion);
            comando.Parameters.AddWithValue("@INDICACIONES_USO", Medicamento.IndicacionesUso);

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







    }// Damedicamento
}// namespace
