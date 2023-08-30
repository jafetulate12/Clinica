using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
     public class EntidadEspecialidad
    {
        // atributos
        private int id_Especialidad;
        private string nombre_Especialidad;
        private string descripcion_Especialidad;
        private bool existe;

        public EntidadEspecialidad()
        {
           id_Especialidad = 0;
           nombre_Especialidad = string.Empty;
           descripcion_Especialidad = string.Empty;
            existe = false;
        }

        public EntidadEspecialidad(int id_Especialidad, string nombre_Especialidad, string descripcion_Especialidad,  bool existe)
        {
            this.id_Especialidad = id_Especialidad;
            this.nombre_Especialidad = nombre_Especialidad;
            this.descripcion_Especialidad = descripcion_Especialidad;
            this.existe = existe;
        }
        //SET GET
        public int Id_Especialidad { get => id_Especialidad; set => id_Especialidad = value; }
        public string Nombre_Especialidad { get => nombre_Especialidad; set => nombre_Especialidad = value; }
        public string Descripcion_Especialidad { get => descripcion_Especialidad; set => descripcion_Especialidad = value; }
        public bool Existe { get => existe; set => existe = value; }


        // SET GET 2
        public int getId_Especialidad()
        {
            return id_Especialidad;
        }

        public string getNombre_Especialidad()
        {
            return nombre_Especialidad;
        }

        public string getDescripcion_Especialidad()
        {
            return descripcion_Especialidad;
        }

        public bool getExiste()
        {
            return existe;
        }


        public void setId_Especialidad(int id_Especialidad)
        {
            this.id_Especialidad = id_Especialidad;
        }

        public void setNombre_Especialidad(string nombre_Especialidad)
        {
            this.nombre_Especialidad = nombre_Especialidad;
        }

        public void setDescripcion_Especialidad(string descripcion_Especialidad)
        {
            this.descripcion_Especialidad = descripcion_Especialidad;
        }

        public void setExiste(bool existe)
        {
            this.existe = existe;
        }

    }// entidad especialidad
}// namespace
