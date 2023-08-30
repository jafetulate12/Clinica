using System;

using CapaEntidades;
using CapaAccesoDatos;
using System.Data;
using System.Collections.Generic;

namespace CapaLogica
{
    public class BLMedicamentos
    {
        //Atributos
        private string _cadenaConexion;
        private string _mensaje;


        public string Mensaje
        {
            get => _mensaje;
        }

        public BLMedicamentos(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }
        //Metodo para llenar insertar de la capa Acceso a datos
        public int Insertar(EntidadMedicamentos Medicamento)
        {
            int id_medicamento = 0;
            DAMedicamentos accesoDatos = new DAMedicamentos(_cadenaConexion);
            try
            {
                id_medicamento = accesoDatos.Insertar(Medicamento);
            }
            catch (Exception)
            {
                throw;
            }

            return id_medicamento;
        }

        public DataSet ListarMedicamentos(string condicion, string orden)
        {
            DataSet DS;
            DAMedicamentos accesoDatos = new DAMedicamentos(_cadenaConexion);
            try
            {
                DS = accesoDatos.ListarMedicamentos(condicion, orden);
            }
            catch (Exception)
            {

                throw;
            }

            return DS;
        }

        

        public EntidadMedicamentos ObtenerMedicamento(int id)
        {
            EntidadMedicamentos Medicamento;
            DAMedicamentos accesoDatos = new DAMedicamentos(_cadenaConexion);
            try
            {
                Medicamento = accesoDatos.obtenerMedicamento(id);
            }
            catch (Exception)
            {

                throw;
            }
            return Medicamento;
        }

        public int EliminarMedicamento(EntidadMedicamentos Medicamento)
        {
            int resultado;
            DAMedicamentos accesoDatos = new DAMedicamentos(_cadenaConexion);
            try
            {
                //Aqui se pueden hacer las validaciones
                //o agregar una logica de programacion 
                resultado = accesoDatos.EliminarMedicamento(Medicamento);

            }
            catch (Exception)
            {
                throw;
            }
            return resultado;
        }

  

        public int ModificarMedicamento(EntidadMedicamentos Medicamento)
        {
            int resultado;
            DAMedicamentos accesoDatos = new DAMedicamentos(_cadenaConexion);
            try
            {
                resultado = accesoDatos.modificarMedicamento(Medicamento);
            }
            catch (Exception)
            {
                throw;
            }
            return resultado;
        }





    }// blmedicamentos
}// fin namespace
