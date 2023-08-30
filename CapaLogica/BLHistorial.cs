using System;
using CapaEntidades;
using CapaAccesoDatos;
using System.Data;
using System.Collections.Generic;

namespace CapaLogica
{
   public class BLHistorial
    {
        //Atributos
        private string _cadenaConexion;
        private string _mensaje;


        public string Mensaje
        {
            get => _mensaje;
        }

        public BLHistorial(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }
        //Metodo para llenar insertar de la capa Acceso a datos
        public int Insertar(EntidadHistorial historial)
        {
            int id_historial = 0;
            DAHistorial accesoDatos = new DAHistorial(_cadenaConexion);
            try
            {
                id_historial = accesoDatos.Insertar(historial);
            }
            catch (Exception)
            {
                throw;
            }

            return id_historial;
        }

        public DataSet ListarHistorial(string condicion, string orden)
        {
            DataSet DS;
            DAHistorial accesoDatos = new DAHistorial(_cadenaConexion);
            try
            {
                DS = accesoDatos.ListarHistorial(condicion, orden);
            }
            catch (Exception)
            {

                throw;
            }

            return DS;
        }


        public EntidadHistorial ObtenerHistorial(int id)
        {
            EntidadHistorial historial;
            DAHistorial accesoDatos = new DAHistorial(_cadenaConexion);
            try
            {
                historial = accesoDatos.obtenerHistorial(id);
            }
            catch (Exception)
            {

                throw;
            }
            return historial;
        }

       
        public int EliminarHistorial(EntidadHistorial historial)
        {
            int resultado;
            DAHistorial accesoDatos = new DAHistorial(_cadenaConexion);
            try
            {
                //Aqui se pueden hacer las validaciones
                //o agregar una logica de programacion 
                resultado = accesoDatos.EliminarHistorial(historial);
            }
            catch (Exception)
            {
                throw;
            }
            return resultado;
        }

        public int ModificarHistorial(EntidadHistorial historial)
        {
            int resultado;
            DAHistorial accesoDatos = new DAHistorial(_cadenaConexion);
            try
            {
                resultado = accesoDatos.modificarHistorial(historial);
            }
            catch (Exception)
            {
                throw;
            }
            return resultado;
        }









    }// fin blhistorial
}// fin namespace
