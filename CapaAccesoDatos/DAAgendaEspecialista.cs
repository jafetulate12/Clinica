using System;
using CapaEntidades;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Collections.Generic;

namespace CapaAccesoDatos
{
    public class DAAgendaEspecialista
    {

        private string _cadenaConexion;
        private string _mensaje;


        public string Mensaje
        {
            get => _mensaje;
        }

        public DAAgendaEspecialista(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

       

        //Devuelve un DataSet de clientes para mostrar en un diagrama
        public DataSet ListarAgenda(string condicion, string orden)
        {
            DataSet datos = new DataSet();//Se guarda la tabla de la consulta de SQL
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            string sentencia = "Select ID_CITAS, ID_ESPECIALISTA, ID_ESPECIALIDAD, HORA_INICIO,HORA_FINAL,FECHA_CITA from AGENDA_ESPECIALISTAS";

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
                adapter.Fill(datos, "Agenda");
            }
            catch (Exception)
            {
                throw;
            }

            return datos;
        }


        //Metodo recibe el ID del ciente y devuelve la entidad cliente

        public EntidadAgendaEspecialista obtenerAgenda(int id)
        {
            EntidadAgendaEspecialista agenda = null;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            SqlDataReader dataReader; //No tiene constructor, se llena con el execute
            string sentencia = string.Format("SELECT ID_CITAS, ID_ESPECIALISTA, ID_ESPECIALIDAD, HORA_INICIO,HORA_FINAL ,FECHA_CITA FROM AGENDA_ESPECIALISTAS WHERE ID_CITAS = {0}", id);

            //Si el id es texto se escribe entre comillas 
            comando.Connection = conexion;
            comando.CommandText = sentencia;

            try
            {
                conexion.Open();
                dataReader = comando.ExecuteReader();
                if (dataReader.HasRows)
                {
                    agenda = new EntidadAgendaEspecialista();
                    dataReader.Read(); //Lee fila or fila del dataReader
                    agenda.Id_Citas = dataReader.GetInt32(0);
                    agenda.Id_Especialista = dataReader.GetInt32(1);
                    agenda.Id_Especialidad = dataReader.GetInt32(2);
                    agenda.Hora_inicio = dataReader.GetTimeSpan(3);
                    agenda.Hora_Final = dataReader.GetTimeSpan(4);
                    agenda.Fecha_Cita = dataReader.GetDateTime(5);
                    agenda.Existe = true;
                }
                conexion.Close();
            }
            catch (Exception)
            {

                throw;
            }
            return agenda;
        }



        //Eliminar sin SP
        public int EliminarAgenda(EntidadAgendaEspecialista Agenda)
        {
            int afectado = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            string sentencia = "DELETE FROM AGENDA_ESPECIALISTAS";
            sentencia = string.Format("{0} WHERE ID_CITAS = {1}", sentencia, Agenda.Id_Citas);
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
        }// eliminar

        public int Insertar(EntidadAgendaEspecialista agenda)
        {//Eliminar un registro mediante un proceso almacenado
            int resultado = 1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "RegistrarCita"; //el nombre del procedimineto almacenado
            //Se especifica que tipo de comando es, en este caso es un SP
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion;
            //parametro de entrada para el SP
            comando.Parameters.AddWithValue("@idEspecialista", agenda.Id_Especialista);
            comando.Parameters.AddWithValue("@idEspecialidad", agenda.Id_Especialidad);
            comando.Parameters.AddWithValue("@horaInicio", agenda.Hora_inicio);
            comando.Parameters.AddWithValue("@horaFinal", agenda.Hora_Final);
            comando.Parameters.AddWithValue("@fechaCita", agenda.Fecha_Cita);
            //parametro de salida del SP
            comando.Parameters.Add("@mensaje", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
            //se declara otro parametro de retorno del SP que optenga el retorno de SP
            comando.Parameters.Add("@retorno", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery(); //ejecuta el SP y se llenan las variables de retorno del SP
                resultado = Convert.ToInt32(comando.Parameters["@retorno"].Value);
                _mensaje = comando.Parameters["@mensaje"].Value.ToString();
            }
            catch (Exception)
            {
                throw;
            }
            return resultado;
        }



    }// DAAgendaEspecialista
}//frm acceso a datos
