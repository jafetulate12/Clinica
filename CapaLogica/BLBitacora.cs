using System;
using CapaEntidades;
using CapaAccesoDatos;
using System.Data;
using System.Collections.Generic;

namespace CapaLogica
{
    public class BLBitacora
    {

        //Atributos
        private string _cadenaConexion;
        private string _mensaje;


        public string Mensaje
        {
            get => _mensaje;
        }
        public BLBitacora(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        public DataSet ListarBitacora(string condicion, string orden)
        {
            DataSet DS;
            DABitacora accesoDatos = new DABitacora(_cadenaConexion);
            try
            {
                DS = accesoDatos.ListarBitacora(condicion, orden);
            }
            catch (Exception)
            {

                throw;
            }

            return DS;
        }








    }// blbitacora
}//namespace
