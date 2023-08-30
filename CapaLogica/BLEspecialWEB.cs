using System;
using CapaEntidades;
using CapaAccesoDatos;
using System.Data;
using System.Collections.Generic;

namespace CapaLogica
{
   public class BLEspecialWEB
    {
        //Atributos
        private string _cadenaConexion;
        private string _mensaje;


        public string Mensaje
        {
            get => _mensaje;
        }

        public BLEspecialWEB(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }
        public int Insertar(EntidadEspecial_WEB agenda)
        {
            int id_agenda = 0;
            BLEspecialWEB accesoDatos = new BLEspecialWEB(_cadenaConexion);
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
            DAEspecialWEB accesoDatos = new DAEspecialWEB(_cadenaConexion);
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

        public EntidadEspecial_WEB ObtenerAgenda(int id)
        {
            EntidadEspecial_WEB agenda;
            DAEspecialWEB accesoDatos = new DAEspecialWEB(_cadenaConexion);
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
}//fin 
