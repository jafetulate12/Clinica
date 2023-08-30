using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    public class EntidadAgendaEspecialista
    {
        private int id_Citas;
        private int id_Especialista;
        private int id_Especialidad;
        private TimeSpan hora_inicio;
        private TimeSpan hora_Final;
        private DateTime? fecha_Cita;
        private bool existe;

        public EntidadAgendaEspecialista(int id_Citas, int id_Especialista, int id_Especialidad, TimeSpan hora_inicio, TimeSpan hora_Final, DateTime? fecha_Cita, bool existe)
        {
            this.id_Citas = id_Citas;
            this.id_Especialista = id_Especialista;
            this.id_Especialidad = id_Especialidad;
            this.hora_inicio = hora_inicio;
            this.hora_Final = hora_Final;
            this.fecha_Cita = fecha_Cita;
            this.existe = existe;
        }

        public int Id_Citas { get => id_Citas; set => id_Citas = value; }
        public int Id_Especialista { get => id_Especialista; set => id_Especialista = value; }
        public int Id_Especialidad { get => id_Especialidad; set => id_Especialidad = value; }
        public TimeSpan Hora_inicio { get => hora_inicio; set => hora_inicio = value; }
        public TimeSpan Hora_Final { get => hora_Final; set => hora_Final = value; }
        public DateTime? Fecha_Cita { get => fecha_Cita; set => fecha_Cita = value; }
        public bool Existe { get => existe; set => existe = value; }


        public EntidadAgendaEspecialista()
        {
            id_Citas = 0;
            id_Especialista = 0;
            id_Especialidad = 0;
            hora_inicio = new TimeSpan(0, 0, 0);
            hora_Final = new TimeSpan(0, 0, 0);
            fecha_Cita = Convert.ToDateTime("01/01/1900");
            existe = false;
        }


        /// set get

        public int getId_Citas()
        {
            return id_Citas;
        }

        public int getId_Especialista()
        {
            return id_Especialista;
        }

        public int getId_Especialidad()
        {
            return id_Especialidad;
        }

        public TimeSpan getHora_inicio()
        {
            return hora_inicio;
        }

        public TimeSpan getHora_Final()
        {
            return hora_Final;
        }

        public DateTime? getFecha_Cita()
        {
            return fecha_Cita;
        }
        //
        public void setId_Citas(int id)
        {
            id_Citas = id;
        }

        public void setId_Especialista(int id)
        {
            id_Especialista = id;
        }

        public void setId_Especialidad(int id)
        {
            id_Especialidad = id;
        }

        public void setHora_inicio(TimeSpan hora)
        {
            hora_inicio = hora;
        }

        public void setHora_Final(TimeSpan hora)
        {
            hora_Final = hora;
        }

        public void setFecha_Cita(DateTime? fecha)
        {
            fecha_Cita = fecha;
        }



    }// fin entidad agenda
}// fin namespace
