using System;
using CapaEntidades;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Collections.Generic;

namespace CapaAccesoDatos
{
    public class DAPagos
    {


        private string _cadenaConexion;
        private string _mensaje;


        public string Mensaje
        {
            get => _mensaje;
        }

        public DAPagos(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        public int Insertar(EntidadPagos pago)
        {
            //Establecer el objeto de conexion
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            //establecer el objeto para ejecutar comandos de sql
            SqlCommand comando = new SqlCommand();
            //devolver valor guardado 
            int id = 0;
            string sentencia = "INSERT INTO PAGOS (ID_FUNCIONARIO, MONTO_PAGO, FECHA_PAGO,TIPO_PAGO,ID_PACIENTE) VALUES(@ID_FUNCIONARIO, @MONTO_PAGO, @FECHA_PAGO,@TIPO_PAGO,@ID_PACIENTE) select @@identity";

            //Pasar la coneccion al command 
            comando.Connection = conexion;
            //Especificar variables
            comando.Parameters.AddWithValue("@ID_FUNCIONARIO", pago.getId_Funcionario());
            comando.Parameters.AddWithValue("@MONTO_PAGO", pago.getMonto_Pago());
            comando.Parameters.AddWithValue("@FECHA_PAGO", pago.getFecha_Pago());
            comando.Parameters.AddWithValue("@TIPO_PAGO", pago.getTipo_Pago());
            comando.Parameters.AddWithValue("@ID_PACIENTE", pago.getId_Paciente());
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
        public DataSet ListarPagos(string condicion, string orden)
        {
            DataSet datos = new DataSet();//Se guarda la tabla de la consulta de SQL
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            string sentencia = "Select ID_FACTURA, ID_FUNCIONARIO, MONTO_PAGO, FECHA_PAGO,TIPO_PAGO,ID_PACIENTE from PAGOS";

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
                adapter.Fill(datos, "Pagos");
            }
            catch (Exception)
            {
                throw;
            }

            return datos;
        }

     
        //Metodo recibe el ID del ciente y devuelve la entidad cliente

        public EntidadPagos obtenerPagos(int id)
        {
            EntidadPagos pago = null;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            SqlDataReader dataReader; //No tiene constructor, se llena con el execute
            string sentencia = string.Format("SELECT ID_FACTURA, ID_FUNCIONARIO, MONTO_PAGO, FECHA_PAGO,TIPO_PAGO,ID_PACIENTE  WHERE ID_FACTURA = {0}", id);

            //Si el id es texto se escribe entre comillas 
            comando.Connection = conexion;
            comando.CommandText = sentencia;

            try
            {
                conexion.Open();
                dataReader = comando.ExecuteReader();
                if (dataReader.HasRows)
                {
                    pago = new EntidadPagos();
                    dataReader.Read(); //Lee fila or fila del dataReader
                    pago.id_Factura = dataReader.GetInt32(0);
                    pago.id_Funcionario = dataReader.GetInt32(1);
                    pago.monto_Pago = dataReader.GetDouble(2);
                    pago.fecha_Pago = dataReader.GetDateTime(3);
                    pago.tipo_Pago = dataReader.GetString(4);
                    pago.id_Paciente = dataReader.GetInt32(5);
                    pago.existe = true;
                }
                conexion.Close();
            }
            catch (Exception)
            {

                throw;
            }
            return pago;
        }

      
        //Eliminar sin SP
        public int EliminarPago(EntidadPagos pago)
        {
            int afectado = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            string sentencia = "DELETE FROM PAGOS";
            sentencia = string.Format("{0} WHERE ID_FACTURA = {1}", sentencia, pago.id_Factura);
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

        public int modificarClientes(EntidadPagos pago)
        {
            int filasAfectadas = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            string sentencia = "UPDATE PAGOS SET ID_FUNCIONARIO= @ID_FUNCIONARIO, MONTO_PAGO= @MONTO_PAGO, FECHA_PAGO= @FECHA_PAGO , TIPO_PAGO= @TIPO_PAGO WHERE ID_FACTURA= @ID_FACTURA";
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@ID_FACTURA", pago.id_Factura);
            comando.Parameters.AddWithValue("@ID_FUNCIONARIO", pago.id_Funcionario);
            comando.Parameters.AddWithValue("@MONTO_PAGO", pago.monto_Pago);
            comando.Parameters.AddWithValue("@FECHA_PAGO", pago.fecha_Pago);
            comando.Parameters.AddWithValue("@TIPO_PAGO", pago.tipo_Pago);
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

    }// fin frm
}// fin namespace
