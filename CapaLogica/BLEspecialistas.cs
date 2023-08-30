using System;
using CapaEntidades;
using CapaAccesoDatos;
using System.Data;
using System.Collections.Generic;

namespace CapaLogica
{
    public class BLEspecialistas
    {
        //Atributos
        private string _cadenaConexion;
        private string _mensaje;


        public string Mensaje
        {
            get => _mensaje;
        }

        public BLEspecialistas(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }
        //Metodo para llenar insertar de la capa Acceso a datos
        public int Insertar(EntidadEspecialistas Especialista)
        {
            int id_especialista = 0;
            DAEspecialistas accesoDatos = new DAEspecialistas(_cadenaConexion);
            try
            {
                id_especialista = accesoDatos.Insertar(Especialista);
            }
            catch (Exception)
            {
                throw;
            }

            return id_especialista;
        }

        public DataSet ListarEspecialista(string condicion, string orden)
        {
            DataSet DS;
            DAEspecialistas accesoDatos = new DAEspecialistas(_cadenaConexion);
            try
            {
                DS = accesoDatos.ListarEspecialistas(condicion, orden);
            }
            catch (Exception)
            {

                throw;
            }

            return DS;
        }

        
        public EntidadEspecialistas ObtenerEspecialista (int id)
        {
            EntidadEspecialistas Especialista;
            DAEspecialistas accesoDatos = new DAEspecialistas(_cadenaConexion);
            try
            {
                Especialista = accesoDatos.obtenerEspecialista(id);
            }
            catch (Exception)
            {

                throw;
            }
            return Especialista;
        }

       

        public int EliminarEspecialista(EntidadEspecialistas Especialista)
        {
            int resultado;
            DAEspecialistas accesoDatos = new DAEspecialistas(_cadenaConexion);
            try
            {
                //Aqui se pueden hacer las validaciones
                //o agregar una logica de programacion 
                resultado = accesoDatos.EliminarEspecialista(Especialista);
            }
            catch (Exception)
            {
                throw;
            }
            return resultado;
        }

        public int ModificarClientes(EntidadEspecialistas Especialista)
        {
            int resultado;
            DAEspecialistas accesoDatos = new DAEspecialistas(_cadenaConexion);
            try
            {
                resultado = accesoDatos.modificarEspecialista(Especialista);

            }
            catch (Exception)
            {
                throw;
            }
            return resultado;
        }


    }
}
