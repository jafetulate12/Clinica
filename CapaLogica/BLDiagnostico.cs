using System;
using CapaEntidades;
using CapaAccesoDatos;
using System.Data;
using System.Collections.Generic;

namespace CapaLogica
{
    public class BLDiagnostico
    {

        //Atributos
        private string _cadenaConexion;
        private string _mensaje;


        public string Mensaje
        {
            get => _mensaje;
        }

        public BLDiagnostico(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }
        //Metodo para llenar insertar de la capa Acceso a datos
        public int Insertar(EntidadDiagnostico diagnostico)
        {
            int id_diagnostico = 0;
            DADiagnostico accesoDatos = new DADiagnostico(_cadenaConexion);
            try
            {
                id_diagnostico = accesoDatos.Insertar(diagnostico);
            }
            catch (Exception)
            {
                throw;
            }

            return id_diagnostico;
        }

        public DataSet ListarDiagnosticos(string condicion, string orden)
        {
            DataSet DS;
            DADiagnostico accesoDatos = new DADiagnostico(_cadenaConexion);
            try
            {
                DS = accesoDatos.ListarDiagnostico(condicion, orden);
            }
            catch (Exception)
            {

                throw;
            }

            return DS;
        }

        

        public EntidadDiagnostico ObtenerDiagnostico(int id)
        {
            EntidadDiagnostico diagnostico;
            DADiagnostico accesoDatos = new DADiagnostico(_cadenaConexion);
            try
            {
                diagnostico = accesoDatos.obtenerDiagnostico(id);
            }
            catch (Exception)
            {

                throw;
            }
            return diagnostico;
        }

      
        public int EliminaDiagnosticos(EntidadDiagnostico diagnostico)
        {
            int resultado;
            DADiagnostico accesoDatos = new DADiagnostico(_cadenaConexion);
            try
            {
                //Aqui se pueden hacer las validaciones
                //o agregar una logica de programacion 
                resultado = accesoDatos.EliminarDiagnostico(diagnostico);
            }
            catch (Exception)
            {
                throw;
            }
            return resultado;
        }

        public int ModificarClientes(EntidadDiagnostico diagnostico)
        {
            int resultado;
            DADiagnostico accesoDatos = new DADiagnostico(_cadenaConexion);
            try
            {
                resultado = accesoDatos.modificarDiagnostico(diagnostico);
            }
            catch (Exception)
            {
                throw;
            }
            return resultado;
        }


    }// fin BLdiagnostico 
}// fin namespace
