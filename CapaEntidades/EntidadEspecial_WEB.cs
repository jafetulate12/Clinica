using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    public class EntidadEspecial_WEB
    {

        private int id_Especialista;
        private string nombre_Completo;
        private string especialidad;
        private TimeSpan hora_inicio;
        private TimeSpan hora_Final;
        private DateTime? fecha_Cita;
        private bool existe;

        public EntidadEspecial_WEB()
        {
            id_Especialista = 0;
            nombre_Completo = string.Empty;
            especialidad = string.Empty;
            hora_inicio = new TimeSpan(0, 0, 0);
            hora_Final = new TimeSpan(0, 0, 0);
            fecha_Cita = Convert.ToDateTime("01/01/1900");
            existe = false;
        }

        public int Id_Especialista { get => id_Especialista; set => id_Especialista = value; }
        public string Nombre_Completo { get => nombre_Completo; set => nombre_Completo = value; }
        public string Especialidad { get => especialidad; set => especialidad = value; }
        public TimeSpan Hora_inicio { get => hora_inicio; set => hora_inicio = value; }
        public TimeSpan Hora_Final { get => hora_Final; set => hora_Final = value; }
        public DateTime? Fecha_Cita { get => fecha_Cita; set => fecha_Cita = value; }
        public bool Existe { get => existe; set => existe = value; }


        public int GetId_Especialista()
        {
            return id_Especialista;
        }

        public void SetId_Especialista(int value)
        {
            id_Especialista = value;
        }

        public string GetNombre_Completo()
        {
            return nombre_Completo;
        }

        public void SetNombre_Completo(string value)
        {
            nombre_Completo = value;
        }

        public string GetEspecialidad()
        {
            return especialidad;
        }

        public void SetEspecialidad(string value)
        {
            especialidad = value;
        }

        public TimeSpan GetHora_Inicio()
        {
            return hora_inicio;
        }

        public void SetHora_Inicio(TimeSpan value)
        {
            hora_inicio = value;
        }

        public TimeSpan GetHora_Final()
        {
            return hora_Final;
        }

        public void SetHora_Final(TimeSpan value)
        {
            hora_Final = value;
        }

        public DateTime? GetFecha_Cita()
        {
            return fecha_Cita;
        }

        public void SetFecha_Cita(DateTime? value)
        {
            fecha_Cita = value;
        }

        public bool GetExiste()
        {
            return existe;
        }

        public void SetExiste(bool value)
        {
            existe = value;
        }




    }
}
