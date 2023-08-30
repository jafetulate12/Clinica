using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    public class EntidadDiagnostico
    {
        private int id_Diagnostico;
        private int id_Especialista;
        private DateTime? fecha_Diagnostico;
        private string resultados_Diagnostico;
        private bool existe;


        public EntidadDiagnostico()
        {
           id_Diagnostico = 0;
           id_Especialista = 0;
           fecha_Diagnostico = Convert.ToDateTime("01/01/1900");
           resultados_Diagnostico = string.Empty;
           existe = false;
        }




        public EntidadDiagnostico(int id_Diagnostico, int id_Especialista, DateTime? fecha_Diagnostico, string resultados_Diagnostico, bool existe)
        {
            this.id_Diagnostico = id_Diagnostico;
            this.id_Especialista = id_Especialista;
            this.fecha_Diagnostico = fecha_Diagnostico;
            this.resultados_Diagnostico = resultados_Diagnostico;
            this.existe = existe;
        }

        public int Id_Diagnostico { get => id_Diagnostico; set => id_Diagnostico = value; }
        public int Id_Especialista { get => id_Especialista; set => id_Especialista = value; }
        public DateTime? Fecha_Diagnostico { get => fecha_Diagnostico; set => fecha_Diagnostico = value; }
        public string Resultados_Diagnostico { get => resultados_Diagnostico; set => resultados_Diagnostico = value; }
        public bool Existe { get => existe; set => existe = value; }

        public int getId_Diagnostico()
        {
            return id_Diagnostico;
        }

        public int getId_Especialista()
        {
            return id_Especialista;
        }

        public DateTime? getFecha_Diagnostico()
        {
            return fecha_Diagnostico;
        }

        public string getResultados_Diagnostico()
        {
            return resultados_Diagnostico;
        }

        public bool getExiste()
        {
            return existe;
        }



        public void setId_Diagnostico(int idDiagnostico)
        {
            id_Diagnostico = idDiagnostico;
        }

        public void setId_Especialista(int idEspecialista)
        {
            id_Especialista = idEspecialista;
        }

        public void setFecha_Diagnostico(DateTime? fechaDiagnostico)
        {
            fecha_Diagnostico = fechaDiagnostico;
        }

        public void setResultados_Diagnostico(string resultadosDiagnostico)
        {
            resultados_Diagnostico = resultadosDiagnostico;
        }

        public void setExiste(bool existe)
        {
            this.existe = existe;
        }

    }// fin entidadDiagnostico
}// fin namespace
