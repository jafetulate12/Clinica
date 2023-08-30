using System;
using CapaEntidades;
using CapaAccesoDatos;
using System.Data;
using System.Collections.Generic;

namespace CapaLogica
{
    public class BLEspecialidad
    {
        //Atributos
        private string _cadenaConexion;
        private string _mensaje;


        public string Mensaje
        {
            get => _mensaje;
        }

        public BLEspecialidad(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }
        //Metodo para llenar insertar de la capa Acceso a datos
        public int Insertar(EntidadEspecialidad especialidad)
        {
            int id_especialidad = 0;
            DAEspecialidad accesoDatos = new DAEspecialidad(_cadenaConexion);
            try
            {
                id_especialidad = accesoDatos.Insertar(especialidad);
            }
            catch (Exception)
            {
                throw;
            }

            return id_especialidad;
        }

        public DataSet ListarEspecialidad(string condicion, string orden)
        {
            DataSet DS;
            DAEspecialidad accesoDatos = new DAEspecialidad(_cadenaConexion);
            try
            {
                DS = accesoDatos.ListarEspecialidad(condicion, orden);
            }
            catch (Exception)
            {

                throw;
            }

            return DS;
        }


        public EntidadEspecialidad ObtenerEspecialidad(int id)
        {
            EntidadEspecialidad especialidad;
            DAEspecialidad accesoDatos = new DAEspecialidad(_cadenaConexion);
            try
            {
                especialidad = accesoDatos.obtenerEspecialidad(id);
            }
            catch (Exception)
            {

                throw;
            }
            return especialidad;
        }

        public int EliminarEspecialidad(EntidadEspecialidad especialidad)
        {
            int resultado;
            DAEspecialidad accesoDatos = new DAEspecialidad(_cadenaConexion);
            try
            {
                //Aqui se pueden hacer las validaciones
                //o agregar una logica de programacion 
                resultado = accesoDatos.EliminarEspecialidad(especialidad);


            }
            catch (Exception)
            {
                throw;
            }
            return resultado;
        }

      
        

        public int ModificarEspecialidad(EntidadEspecialidad especialidad)
        {
            int resultado;
            DAEspecialidad accesoDatos = new DAEspecialidad(_cadenaConexion);
            try
            {
                resultado = accesoDatos.modificarEspecialidad(especialidad);
            }
            catch (Exception)
            {
                throw;
            }
            return resultado;
        }



    }// fin BLEspecialidad
}// fin namespcae
