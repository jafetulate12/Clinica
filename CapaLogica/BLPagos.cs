using System;
using CapaEntidades;
using CapaAccesoDatos;
using System.Data;
using System.Collections.Generic;

namespace CapaLogica
{
    public class BLPagos
    {
        //Atributos
        private string _cadenaConexion;
        private string _mensaje;


        public string Mensaje
        {
            get => _mensaje;
        }

        public BLPagos(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }
        //Metodo para llenar insertar de la capa Acceso a datos
        public int Insertar(EntidadPagos pago)
        {
            int id_pago = 0;
            DAPagos accesoDatos = new DAPagos(_cadenaConexion);
            try
            {
                id_pago = accesoDatos.Insertar(pago);
            }
            catch (Exception)
            {
                throw;
            }

            return id_pago;
        }

        public DataSet ListarPago(string condicion, string orden)
        {
            DataSet DS;
            DAPagos accesoDatos = new DAPagos(_cadenaConexion);
            try
            {
                DS = accesoDatos.ListarPagos(condicion, orden);
            }
            catch (Exception)
            {

                throw;
            }

            return DS;
        }

       

        public EntidadPagos ObtenerPago(int id)
        {
            EntidadPagos pago;
            DAPagos accesoDatos = new DAPagos(_cadenaConexion);
            try
            {
                pago = accesoDatos.obtenerPagos(id);
            }
            catch (Exception)
            {

                throw;
            }
            return pago;
        }

       
        public int EliminarPago(EntidadPagos pago)
        {
            int resultado;
            DAPagos accesoDatos = new DAPagos(_cadenaConexion);
            try
            {
                //Aqui se pueden hacer las validaciones
                //o agregar una logica de programacion 
                resultado = accesoDatos.EliminarPago(pago);
            }
            catch (Exception)
            {
                throw;
            }
            return resultado;
        }

        public int ModificarPago(EntidadPagos pago)
        {
            int resultado;
            DAPagos accesoDatos = new DAPagos(_cadenaConexion);
            try
            {
                resultado = accesoDatos.modificarClientes(pago);
            }
            catch (Exception)
            {
                throw;
            }
            return resultado;
        }

    }// blpagos
}// namespace
