using System;
using CapaEntidades;
using CapaAccesoDatos;
using System.Data;
using System.Collections.Generic;

namespace CapaLogica
{
    public class BLCitaWeb
    {
        //Atributos
        private string _cadenaConexion;
        private string _mensaje;


        public string Mensaje
        {
            get => _mensaje;
        }

        public BLCitaWeb(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }


        
        public DataSet listarCita(string condicion, string orden)
        {
            DataSet DS;
            DACitaWeb accesoDatos = new DACitaWeb(_cadenaConexion);
            try
            {
                DS = accesoDatos.ListarCita(condicion, orden);
            }
            catch (Exception)
            {

                throw;
            }

            return DS;
        }
        //Metodo para llenar insertar de la capa Acceso a datos
        public int Insertar(EntidaCitaWeb Cita)
        {
            int id_agenda = 0;
            DACitaWeb accesoDatos = new DACitaWeb(_cadenaConexion);
            try
            {
                id_agenda = accesoDatos.Insertar(Cita);
                _mensaje = accesoDatos.Mensaje;
            }
            catch (Exception)
            {
                throw;
            }

            return id_agenda;
        }






    }
}
