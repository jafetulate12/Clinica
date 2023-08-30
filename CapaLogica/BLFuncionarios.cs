using System;
using CapaEntidades;
using CapaAccesoDatos;
using System.Data;
using System.Collections.Generic;

namespace CapaLogica
{
    public class BLFuncionarios
    {
        //Atributos
        private string _cadenaConexion;
        private string _mensaje;


        public string Mensaje
        {
            get => _mensaje;
        }

        public BLFuncionarios(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }
        //Metodo para llenar insertar de la capa Acceso a datos
        public int Insertar(EntidadFuncionarios funcionario)
        {
            int id_funcionario = 0;
            DAFuncionarios accesoDatos = new DAFuncionarios(_cadenaConexion);
            try
            {
                id_funcionario = accesoDatos.Insertar(funcionario);
            }
            catch (Exception)
            {
                throw;
            }
            return id_funcionario;
        }// fin insertar

        public DataSet ListarClientes(string condicion, string orden)
        {
            DataSet DS;
            DAFuncionarios accesoDatos = new DAFuncionarios(_cadenaConexion);
            try
            {
                DS = accesoDatos.ListarFuncionario(condicion, orden);
            }
            catch (Exception)
            {

                throw;
            }

            return DS;
        }// fin listar

        public EntidadFuncionarios ObtenerFuncionario(int id)
        {
            EntidadFuncionarios funcionario;
            DAFuncionarios accesoDatos = new DAFuncionarios (_cadenaConexion);
            try
            {
                funcionario = accesoDatos.obtenerCliente(id);
            }
            catch (Exception)
            {

                throw;
            }
            return funcionario;
        }// fin obtener funcionario


        public int ModificarClientes(EntidadFuncionarios funcionario)
        {
            int resultado;
            DAFuncionarios accesoDatos = new DAFuncionarios(_cadenaConexion);
            try
            {
                resultado = accesoDatos.modificarClientes(funcionario);
            }
            catch (Exception)
            {
                throw;
            }
            return resultado;
        }// fin  modificar


        public int EliminarFuncionario(EntidadFuncionarios funcionario)
        {
            int resultado;
            DAFuncionarios accesoDatos = new DAFuncionarios(_cadenaConexion);
            try
            {
                //Aqui se pueden hacer las validaciones
                //o agregar una logica de programacion 
                resultado = accesoDatos.EliminarFuncionario(funcionario);
            }
            catch (Exception)
            {
                throw;
            }
            return resultado;
        }// fin eliminar






    }// fin blfuncionarios
}// fin namespace
