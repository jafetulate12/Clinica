using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    public class EntidadMedicamentos
    {


        private int idMedicamento;
        private string nombreMedicamento;
        private string descripcion;
        private string indicacionesUso;
        private bool existe;

        public int IdMedicamento { get => idMedicamento; set => idMedicamento = value; }
        public string NombreMedicamento { get => nombreMedicamento; set => nombreMedicamento = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string IndicacionesUso { get => indicacionesUso; set => indicacionesUso = value; }
        public bool Existe { get => existe; set => existe = value; }

        public EntidadMedicamentos(int idMedicamento, string nombreMedicamento, string descripcion, string indicacionesUso,bool Existe)
        {
            IdMedicamento = idMedicamento;
            NombreMedicamento = nombreMedicamento;
            Descripcion = descripcion;
            IndicacionesUso = indicacionesUso;
            this.Existe = Existe;
        }


        public EntidadMedicamentos()
        {
            IdMedicamento = 0;
            NombreMedicamento = string.Empty;
            Descripcion = string.Empty;
            IndicacionesUso = string.Empty;
            Existe = false;
        }
        // get set
        public void setIdMedicamento(int idMedicamento)
        {
            IdMedicamento = idMedicamento;
        }

        public void setNombreMedicamento(string nombreMedicamento)
        {
            NombreMedicamento = nombreMedicamento;
        }

        public void setDescripcion(string descripcion)
        {
            Descripcion = descripcion;
        }

        public void setIndicacionesUso(string indicacionesUso)
        {
            IndicacionesUso = indicacionesUso;
        }
        public void setExiste(bool Existe)
        {
            this.Existe = Existe;
        }

        // get set
        public int getIdMedicamento()
        {
            return IdMedicamento;
        }

        public string getNombreMedicamento()
        {
            return NombreMedicamento;
        }

        public string getDescripcion()
        {
            return Descripcion;
        }

        public string getIndicacionesUso()
        {
            return IndicacionesUso;
        }

        public bool getExiste()
        {
            return Existe;
        }

    }
}
