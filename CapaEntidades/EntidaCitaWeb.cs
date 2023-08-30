using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    public class EntidaCitaWeb
    {

        private int id_cita_Web;
        private int id_Especialista;
        private int id_Paciente;
        private TimeSpan hora_Inicio;
        private DateTime? fecha;

        public int Id_cita_Web { get => id_cita_Web; set => id_cita_Web = value; }
        public int Id_Especialista { get => id_Especialista; set => id_Especialista = value; }
        public int Id_Paciente { get => id_Paciente; set => id_Paciente = value; }
        public TimeSpan Hora_Inicio { get => hora_Inicio; set => hora_Inicio = value; }
        public DateTime? Fecha { get => fecha; set => fecha = value; }

        public EntidaCitaWeb(int id_cita_Web, int id_Especialista, int id_Paciente, TimeSpan hora_Inicio, DateTime? fecha)
        {
            this.Id_cita_Web = id_cita_Web;
            this.Id_Especialista = id_Especialista;
            this.Id_Paciente = id_Paciente;
            this.hora_Inicio = hora_Inicio;
           this. fecha = fecha;
        }

        public EntidaCitaWeb()
        {
           Id_cita_Web = 0;
           Id_Especialista =0 ;
            Id_Paciente =0 ;
            hora_Inicio = new TimeSpan(0, 0, 0); ;
            fecha = Convert.ToDateTime("01/01/1900"); 
        }

        public int getId_Cita_Web()
        {
            return Id_cita_Web;
        }

        public void setId_Cita_Web(int id)
        {
            Id_cita_Web = id;
        }

        public int getId_Especialista()
        {
            return id_Especialista;
        }

        public void setId_Especialista(int id)
        {
            id_Especialista = id;
        }

        public int getId_Paciente()
        {
            return id_Paciente;
        }

        public void setId_Paciente(int id)
        {
            id_Paciente = id;
        }

        public TimeSpan getHora_Inicio()
        {
            return hora_Inicio;
        }

        public void setHora_Inicio(TimeSpan hora)
        {
            hora_Inicio = hora;
        }
        public DateTime? getFecha()
        {
            return fecha;
        }

        public void setFecha(DateTime? fecha)
        {
            this.fecha = fecha;
        }



    }
}
