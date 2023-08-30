using System;
using CapaEntidades;
using CapaAccesoDatos;
using System.Data;
using System.Collections.Generic;

namespace CapaLogica
{
    public class BLAgenda
    {
        //Atributos
        private string _cadenaConexion;
        private string _mensaje;


        public string Mensaje
        {
            get => _mensaje;
        }

        public BLAgenda(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }
        //Metodo para llenar insertar de la capa Acceso a datos
        public int Insertar(EntidadAgendaEspecialista agenda)
        {
            int id_agenda = 0;
            DAAgendaEspecialista accesoDatos = new DAAgendaEspecialista(_cadenaConexion);
            try
            {
                id_agenda = accesoDatos.Insertar(agenda);
                _mensaje = accesoDatos.Mensaje;
            }
            catch (Exception)
            {
                throw;
            }

            return id_agenda;
        }

        public DataSet ListarAgenda(string condicion, string orden)
        {
            DataSet DS;
            DAAgendaEspecialista accesoDatos = new DAAgendaEspecialista(_cadenaConexion);
            try
            {
                DS = accesoDatos.ListarAgenda(condicion, orden);
            }
            catch (Exception)
            {

                throw;
            }

            return DS;
        }

        public int EliminarAgenda(EntidadAgendaEspecialista agenda)
        {
            int resultado;
            DAAgendaEspecialista accesoDatos = new DAAgendaEspecialista(_cadenaConexion);
            try
            {
                //Aqui se pueden hacer las validaciones
                //o agregar una logica de programacion 
                resultado = accesoDatos.EliminarAgenda(agenda);
                _mensaje = accesoDatos.Mensaje;

            }
            catch (Exception)
            {
                throw;
            }
            return resultado;
        }

        public  EntidadAgendaEspecialista ObtenerAgenda(int id)
        {
            EntidadAgendaEspecialista agenda;
            DAAgendaEspecialista accesoDatos = new DAAgendaEspecialista (_cadenaConexion);
            try
            {
                agenda = accesoDatos.obtenerAgenda(id);
            }
            catch (Exception)
            {

                throw;
            }
            return agenda;
        }

    }// fin bl
}// fin namespace
