using System;
using CapaEntidades;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Collections.Generic;

namespace CapaAccesoDatos
{
    public class DACitaWeb
    {


        private string _cadenaConexion;
        private string _mensaje;


        public string Mensaje
        {
            get => _mensaje;
        }

        public DACitaWeb(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        /// <summary>
        /// eSTE METODO LISTA LAS CITAS AGENDADAS
        /// </summary>
        /// <param name="condicion"></param>
        /// <param name="orden"></param>
        /// <returns></returns>
        public DataSet ListarCita(string condicion, string orden)
        {
            DataSet datos = new DataSet();//Se guarda la tabla de la consulta de SQL
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            string sentencia = "SELECT ID_CITA_WEB, CW.ID_ESPECIALISTA, E.NOMBRE_COMPLETO, P.ID_PACIENTE, P.NOMBRE_COMPLETO_PACIENTE,  CW.HORA_INICIO, CW.FECHA FROM AGENDA_CITA_WEB CW INNER JOIN PACIENTES P ON CW.ID_PACIENTE = P.ID_PACIENTE INNER JOIN ESPECIALISTAS_WEB E ON CW.ID_ESPECIALISTA = E.ID_ESPECIALISTA";

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
                adapter.Fill(datos, "Cita");
            }
            catch (Exception)
            {
                throw;
            }

            return datos;
        }

















       /// <summary>
       /// Este metodo inserta la cita y hace las validacione de que no este en el horario asignado o fuera del horario
       /// </summary>
       /// <param name="Cita"></param>
       /// <returns></returns>

       //--------------INSERTAR CITA VALIDACIONES Y MAS
          public int Insertar(EntidaCitaWeb Cita)
        {//Eliminar un registro mediante un proceso almacenado
            int resultado = 1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "InsertarCita"; //el nombre del procedimineto almacenado
            //Se especifica que tipo de comando es, en este caso es un SP
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion;
            //parametro de entrada para el SP
            comando.Parameters.AddWithValue("@ID_ESPECIALISTA", Cita.Id_Especialista);
            comando.Parameters.AddWithValue("@ID_PACIENTE", Cita.Id_Paciente);
            comando.Parameters.AddWithValue("@HORA_INICIO", Cita.Hora_Inicio);
            comando.Parameters.AddWithValue("@FECHA", Cita.Fecha);
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





    }
}
