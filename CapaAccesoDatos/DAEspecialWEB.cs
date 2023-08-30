using System;
using CapaEntidades;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Collections.Generic;

namespace CapaAccesoDatos
{
    public class DAEspecialWEB
    {
        private string _cadenaConexion;
        private string _mensaje;


        public string Mensaje
        {
            get => _mensaje;
        }

        public DAEspecialWEB(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        public DataSet ListarAgenda(string condicion, string orden)
        {
            DataSet datos = new DataSet();//Se guarda la tabla de la consulta de SQL
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            string sentencia = "Select ID_ESPECIALISTA, NOMBRE_COMPLETO, ESPECIALIDAD, HORA_INICIO,HORA_FINAL,FECHA from ESPECIALISTAS_WEB";

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


        public EntidadEspecial_WEB obtenerAgenda(int id)
        {
            EntidadEspecial_WEB agenda = null;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            SqlDataReader dataReader; //No tiene constructor, se llena con el execute
            string sentencia = string.Format("ID_ESPECIALISTA, NOMBRE_COMPLETO,ESPECIALIDAD,HORA_INICIO,HORA_FINAL,FECHA  FROM ESPECIALISTAS_WEB WHERE ID_ESPECIALISTA = {0}", id);

            //Si el id es texto se escribe entre comillas 
            comando.Connection = conexion;
            comando.CommandText = sentencia;

            try
            {
                conexion.Open();
                dataReader = comando.ExecuteReader();
                if (dataReader.HasRows)
                {
                    agenda = new EntidadEspecial_WEB();
                    dataReader.Read(); //Lee fila or fila del dataReader
                    agenda.Id_Especialista = dataReader.GetInt32(0);
                    agenda.Nombre_Completo = dataReader.GetString(1);
                    agenda.Especialidad = dataReader.GetString(2);
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





    }// FIN DA
}// FIN 
