using System;
using CapaEntidades;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Collections.Generic;

namespace CapaAccesoDatos
{
     public class DAFuncionarios
    {
        // atributos
        private string _cadenaConexion;
        private string _mensaje;


        public string Mensaje
        {
            get => _mensaje;
        }// fin mensaje

        public DAFuncionarios(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }// cadena conexion

        public int Insertar(EntidadFuncionarios funcionario)
        {
            //Establecer el objeto de conexion
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            //establecer el objeto para ejecutar comandos de sql
            SqlCommand comando = new SqlCommand();
            //devolver valor guardado 
            int id = 0;
            string sentencia = "INSERT INTO FUNCIONARIOS( PUESTO_FUNCIONARIO,NOMBRE_COMPLETO_FUNCIONARIO,TELEFONO_FUNCIONARIO, CORREO_FUNCIONARIO) VALUES( @PUESTO_FUNCIONARIO,@NOMBRE_COMPLETO_FUNCIONARIO, @TELEFONO_FUNCIONARIO, @CORREO_FUNCIONARIO) select @@identity";

            //Pasar la coneccion al command 
            comando.Connection = conexion;
            //Especificar variables
            comando.Parameters.AddWithValue("@PUESTO_FUNCIONARIO", funcionario.GetPuesto_Funcionario());
            comando.Parameters.AddWithValue("@NOMBRE_COMPLETO_FUNCIONARIO", funcionario.GetNombre_Completo_Funcionario());
            comando.Parameters.AddWithValue("@TELEFONO_FUNCIONARIO", funcionario.GetTelefono_Funcionario());
            comando.Parameters.AddWithValue("@CORREO_FUNCIONARIO", funcionario.GetCorreo_Funcionario());
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
        }// fin metodo insertar

        //Devuelve un DataSet de clientes para mostrar en un diagrama
        public DataSet ListarFuncionario(string condicion, string orden)
        {
            DataSet datos = new DataSet();//Se guarda la tabla de la consulta de SQL
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            string sentencia = "SELECT ID_FUNCIONARIO,PUESTO_FUNCIONARIO ,NOMBRE_COMPLETO_FUNCIONARIO, TELEFONO_FUNCIONARIO,CORREO_FUNCIONARIO FROM FUNCIONARIOS ";

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
                adapter.Fill(datos, "Funcionarios");
            }
            catch (Exception)
            {
                throw;
            }

            return datos;
        } // FIN LISTAR FUNCIONARIOS

        //Metodo recibe el ID del ciente y devuelve la entidad cliente

        public EntidadFuncionarios obtenerCliente(int id)

        {
            EntidadFuncionarios funcionario = null;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            SqlDataReader dataReader; //No tiene constructor, se llena con el execute
            string sentencia = string.Format("SELECT ID_FUNCIONARIO,PUESTO_FUNCIONARIO ,NOMBRE_COMPLETO_FUNCIONARIO,TELEFONO_FUNCIONARIO,CORREO_FUNCIONARIO FROM FUNCIONARIOS WHERE ID_FUNCIONARIO ={0} ", id);

            //Si el id es texto se escribe entre comillas 
            comando.Connection = conexion;
            comando.CommandText = sentencia;

            try
            {
                conexion.Open();
                dataReader = comando.ExecuteReader();
                if (dataReader.HasRows)
                {
                    funcionario = new EntidadFuncionarios();
                    dataReader.Read(); //Lee fila or fila del dataReader
                    funcionario.Id_Funcionario = dataReader.GetInt32(0);
                    funcionario.Puesto_Funcionario = dataReader.GetString(1);
                    funcionario.Nombre_Completo_Funcionario = dataReader.GetString(2);
                    funcionario.Telefono_Funcionario = dataReader.GetInt32(3);
                    funcionario.Correo_Funcionario = dataReader.GetString(4);
                    funcionario.Existe = true;
                }
                conexion.Close();
            }
            catch (Exception)
            {

                throw;
            }
            return funcionario;
        }// fin obtener cliente

        public int modificarClientes(EntidadFuncionarios funcionario)
        {
            int filasAfectadas = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            string sentencia = "UPDATE FUNCIONARIOS SET PUESTO_FUNCIONARIO=@PUESTO_FUNCIONARIO, NOMBRE_COMPLETO_FUNCIONARIO = @NOMBRE_COMPLETO_FUNCIONARIO ,TELEFONO_FUNCIONARIO = @TELEFONO_FUNCIONARIO, CORREO_FUNCIONARIO = @CORREO_FUNCIONARIO";
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@ID_FUNCIONARIO", funcionario.Id_Funcionario);
            comando.Parameters.AddWithValue("@PUESTO_FUNCIONARIO", funcionario.Puesto_Funcionario);
            comando.Parameters.AddWithValue("@NOMBRE_COMPLETO_FUNCIONARIO", funcionario.Nombre_Completo_Funcionario);
            comando.Parameters.AddWithValue("@TELEFONO_FUNCIONARIO", funcionario.Telefono_Funcionario);
            comando.Parameters.AddWithValue("@CORREO_FUNCIONARIO", funcionario.Correo_Funcionario);


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
        // eliminar funcionario
        public int EliminarFuncionario(EntidadFuncionarios funcionario)
        {
            int afectado = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            string sentencia = "DELETE FROM FUNCIONARIOS";
            sentencia = string.Format("{0} WHERE ID_FUNCIONARIO = {1}", sentencia, funcionario.Id_Funcionario);
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


    }// fin DAFUNCIONARIOS
}// FIN NAMESPACE
