using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    public class EntidadHistorial
    { 
        // atributos
        private int idHistorial;
        private int idPaciente;
        private int idMedicamento;
        private int idDiagnosticoe;
        private bool existe;

        public EntidadHistorial()
        {
            idHistorial = 0;
            idPaciente = 0;
            idMedicamento = 0;
            idDiagnosticoe = 0;
            existe = false;
        }

        public int IdHistorial { get => idHistorial; set => idHistorial = value; }
        public int IdPaciente { get => idPaciente; set => idPaciente = value; }
        public int IdMedicamento { get => idMedicamento; set => idMedicamento = value; }
        public int IdDiagnosticoe { get => idDiagnosticoe; set => idDiagnosticoe = value; }
        public bool Existe { get => existe; set => existe = value; }


        public void setIdHistorial(int idHistorial)
        {
            this.idHistorial = idHistorial;
        }

        public void setIdPaciente(int idPaciente)
        {
            this.idPaciente = idPaciente;
        }

        public void setIdMedicamento(int idMedicamento)
        {
            this.idMedicamento = idMedicamento;
        }

        public void setIdDiagnostico(int idDiagnostico)
        {
            this.IdDiagnosticoe = idDiagnostico;
        }



        public void setExiste(bool existe)
        {
            this.existe = existe;
        }


        public int getIdHistorial()
        {
            return idHistorial;
        }

        public int getIdPaciente()
        {
            return idPaciente;
        }

        public int getIdMedicamento()
        {
            return idMedicamento;
        }

        public int getIdDiagnostico()
        {
            return IdDiagnosticoe;
        }


        public bool getExiste()
        {
            return existe;
        }


    }// fin entidad Historial
}// namespace
