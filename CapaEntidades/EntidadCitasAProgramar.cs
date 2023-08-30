using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    public class EntidadCitasAProgramar
    {

        private int cita_A_Programar;
        private int id_Funcionario;
        private int id_Cita;
        private int id_Paciente;
        private bool existe;

        public EntidadCitasAProgramar()
        {
           cita_A_Programar = 0;
           id_Funcionario = 0;
            id_Cita = 0;
            id_Paciente = 0;
            existe = false;
        }



        public EntidadCitasAProgramar(int cita_A_Programar, int id_Funcionario, int id_Cita, int id_Paciente, bool existe)
        {
            this.cita_A_Programar = cita_A_Programar;
            this.id_Funcionario = id_Funcionario;
            this.id_Cita = id_Cita;
            this.id_Paciente = id_Paciente;
            this.existe = existe;
        }

        public int Cita_A_Programar { get => cita_A_Programar; set => cita_A_Programar = value; }
        public int Id_Funcionario { get => id_Funcionario; set => id_Funcionario = value; }
        public int Id_Cita { get => id_Cita; set => id_Cita = value; }
        public int Id_Paciente { get => id_Paciente; set => id_Paciente = value; }
        public bool Existe { get => existe; set => existe = value; }


        public void SetCita_A_Programar(int cita_A_Programar)
        {
            this.cita_A_Programar = cita_A_Programar;
        }

        public void SetId_Funcionario(int id_Funcionario)
        {
            this.id_Funcionario = id_Funcionario;
        }

        public void SetId_Cita(int id_Cita)
        {
            this.id_Cita = id_Cita;
        }

        public void SetId_Paciente(int id_Paciente)
        {
            this.id_Paciente = id_Paciente;
        }

        public void SetExiste(bool existe)
        {
            this.existe = existe;
        }


        public int GetCita_A_Programar()
        {
            return cita_A_Programar;
        }

        public int GetId_Funcionario()
        {
            return id_Funcionario;
        }

        public int GetId_Cita()
        {
            return id_Cita;
        }

        public int GetId_Paciente()
        {
            return id_Paciente;
        }

        public bool GetExiste()
        {
            return existe;
        }




    }// fin Entidad
}// namespace
