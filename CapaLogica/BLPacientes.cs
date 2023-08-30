using System;
using CapaEntidades;
using CapaAccesoDatos;
using System.Data;
using System.Collections.Generic;

namespace CapaLogica
{
    public class BLPacientes
    {
        //atributos
        // atributos
        private string _cadenaConexion;
        private string _mensaje;

        public string Mensaje
        {
            get => _mensaje;
        }

        public BLPacientes(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        // metodo para llamar insertar a la capa de acceco a datos

        public int insertar(EntidadPacientes pacientes)
        {
            int id_paciente = 0;
            DAPacientes accesoDatos = new DAPacientes(_cadenaConexion);
            try
            {
                id_paciente = accesoDatos.insertar(pacientes);
            }
            catch (Exception)
            {

                throw;
            }
            return id_paciente;
        }// fin clase insertar

        //llamar lista de clientes
        public DataSet ListarPacientes(string condicion, string orden)
        {
            DataSet DS;
            DAPacientes accesoDatos = new DAPacientes(_cadenaConexion);
            try
            {
                DS = accesoDatos.ListarPacientes(condicion, orden);
            }
            catch (Exception)
            {

                throw;
            }
            return DS;
        }// listar pacientes

        // clase eliminar
        public int EliminarPaciente(EntidadPacientes pacientes)
        {
            int resultado;
            DAPacientes accesoDatos = new DAPacientes(_cadenaConexion);
            try
            {
                resultado = accesoDatos.EliminarPaciente(pacientes);
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;
        }// elminar sin SP


        public int EliminarConSP(EntidadPacientes paciente)
        {
            int resultado;
            DAPacientes accesoDatos = new DAPacientes(_cadenaConexion);
            try
            {
                // aqui antes de eliminar se podria verificar si es posible eliminar
                resultado = accesoDatos.EliminarRegistroConSP(paciente);
                _mensaje = accesoDatos.Mensaje;
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;
        }//EliminarConSP





        public EntidadPacientes obtenerPaciente(int id)
        {
            EntidadPacientes pacientes;
            DAPacientes accesoDatos = new DAPacientes(_cadenaConexion);
            try
            {
                pacientes = accesoDatos.obtenerPaciente(id);
            }
            catch (Exception)
            {

                throw;
            }
            return pacientes;
        }// obtebner

        public int ModificarPacientes(EntidadPacientes pacientes)
        {
            int resultado;
            DAPacientes accesoDatos = new DAPacientes(_cadenaConexion);
            try
            {
                resultado = accesoDatos.modificarPacientes(pacientes);
            }
            catch (Exception)
            {
                throw;
            }
            return resultado;
        }



    }// fin BLPacientes
}// fin namespace
