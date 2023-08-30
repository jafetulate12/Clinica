using System;
using CapaEntidades;
using CapaAccesoDatos;
using System.Data;
using System.Collections.Generic;

namespace CapaLogica
{
    public class BLCitas
    {
        //Atributos
        private string _cadenaConexion;
        private string _mensaje;


        public string Mensaje
        {
            get => _mensaje;
        }

        public BLCitas(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }
        //Metodo para llenar insertar de la capa Acceso a datos
        public int Insertar(EntidadCitasAProgramar cita)
        {
            int id_cita = 0;
            DACitasAProgramar accesoDatos = new DACitasAProgramar(_cadenaConexion);
            try
            {
                id_cita = accesoDatos.Insertar(cita);
                _mensaje = accesoDatos.Mensaje;
            }
            catch (Exception)
            {
                throw;
            }

            return id_cita;
        }

        public DataSet ListarCita(string condicion, string orden)
        {
            DataSet DS;
            DACitasAProgramar accesoDatos = new DACitasAProgramar(_cadenaConexion);
            try
            {
                DS = accesoDatos.ListarCitas(condicion, orden);
            }
            catch (Exception)
            {

                throw;
            }

            return DS;
        }

        public int EliminarCita(EntidadCitasAProgramar cita)
        {
            int resultado;
            DACitasAProgramar accesoDatos = new DACitasAProgramar(_cadenaConexion);
            try
            {
                //Aqui se pueden hacer las validaciones
                //o agregar una logica de programacion 
                resultado = accesoDatos.EliminarCita(cita);
            }
            catch (Exception)
            {
                throw;
            }
            return resultado;
        }

        public EntidadAgendaEspecialista ObtenerAgenda(int id)
        {
            EntidadAgendaEspecialista agenda;
            DAAgendaEspecialista accesoDatos = new DAAgendaEspecialista(_cadenaConexion);
            try
            {
                agenda = accesoDatos.obtenerAgenda(id);
            }
            catch (Exception)
            {

                throw;
            }
            return agenda;
        }

        public EntidadCitasAProgramar ObtenerCita(int id)
        {
            EntidadCitasAProgramar cita;
            DACitasAProgramar accesoDatos = new DACitasAProgramar(_cadenaConexion);
            try
            {
                cita = accesoDatos.obtenerCita(id);
            }
            catch (Exception)
            {

                throw;
            }
            return cita;
        }











    } // blcitas
}// namespcae
