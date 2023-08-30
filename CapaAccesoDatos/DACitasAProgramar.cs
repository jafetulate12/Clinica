using System;
using CapaEntidades;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Collections.Generic;

namespace CapaAccesoDatos
{
    public class DACitasAProgramar
    {

        private string _cadenaConexion;
        private string _mensaje;


        public string Mensaje
        {
            get => _mensaje;
        }

        public DACitasAProgramar(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }
        /// <summary>
        /// Este metodo lo que hace es que emediante un proceso almacena inserta la cita y hace las validadciones
        /// </summary>
        /// <param name="cita"></param>
        /// <returns></returns>
        public int Insertar(EntidadCitasAProgramar cita)
        {//Eliminar un registro mediante un proceso almacenado
            int resultado = 1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "regiCita"; //el nombre del procedimineto almacenado
            //Se especifica que tipo de comando es, en este caso es un SP
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion;
            //parametro de entrada para el SP
            comando.Parameters.AddWithValue("@IDAgendaEspecialista", cita.Id_Cita);
            comando.Parameters.AddWithValue("@IdFuncionario", cita.Id_Funcionario);
            comando.Parameters.AddWithValue("@IdPaciente", cita.Id_Paciente);
          
            //parametro de salida del SP
            comando.Parameters.Add("@msj", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
            //se declara otro parametro de retorno del SP que optenga el retorno de SP
            comando.Parameters.Add("@retorno", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery(); //ejecuta el SP y se llenan las variables de retorno del SP
                resultado = Convert.ToInt32(comando.Parameters["@retorno"].Value);
                _mensaje = comando.Parameters["@msj"].Value.ToString();
            }
            catch (Exception)
            {
                throw;
            }
            return resultado;
        }

        public int EliminarCita(EntidadCitasAProgramar cita)
        {
            int afectado = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            string sentencia = "DELETE FROM CITAS_A_PROGRAMAR";
            sentencia = string.Format("{0} WHERE ID_CITA_PROGRAMADA = {1}", sentencia, cita.Cita_A_Programar);
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

        public DataSet ListarCitas(string condicion, string orden)
        {
            DataSet datos = new DataSet();//Se guarda la tabla de la consulta de SQL
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            string sentencia = "Select ID_CITA_PROGRAMADA, ID_FUNCIONARIO, ID_CITAS, ID_PACIENTE from CITAS_A_PROGRAMAR";

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
                adapter.Fill(datos, "Citas");
            }
            catch (Exception)
            {
                throw;
            }

            return datos;
        }



        public EntidadCitasAProgramar obtenerCita(int id)
        {
            EntidadCitasAProgramar cita = null;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            SqlDataReader dataReader; //No tiene constructor, se llena con el execute
            string sentencia = string.Format("SELECT ID_CITA_PROGRAMADA, ID_FUNCIONARIO, ID_CITAS, ID_PACIENTE FROM CITAS_A_PROGRAMAR WHERE ID_CITA_PROGRAMADA = {0}", id);

            //Si el id es texto se escribe entre comillas 
            comando.Connection = conexion;
            comando.CommandText = sentencia;

            try
            {
                conexion.Open();
                dataReader = comando.ExecuteReader();
                if (dataReader.HasRows)
                {
                    cita = new EntidadCitasAProgramar();
                    dataReader.Read(); //Lee fila or fila del dataReader
                    cita.Cita_A_Programar = dataReader.GetInt32(0);
                    cita.Id_Funcionario = dataReader.GetInt32(1);
                    cita.Id_Cita = dataReader.GetInt32(2);
                    cita.Id_Paciente = dataReader.GetInt32(3);
                    cita.Existe = true;
                }
                conexion.Close();
            }
            catch (Exception)
            {

                throw;
            }
            return cita;
        }


    }// dacitasaprogramar
}// fin namespae
