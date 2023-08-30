using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    public class EntidadEspecialistas
    {
        // atributos
        private int id_Especialista;
        private string nombre_Especialista;
        private int telefono_Especialista;
        private string corro_Especialista;
        private string direccion_Especialista;
        private bool existe;
        // set get 

        public int Id_Especialista { get => id_Especialista; set => id_Especialista = value; }
        public string Nombre_Especialista { get => nombre_Especialista; set => nombre_Especialista = value; }
        public int Telefono_Especialista { get => telefono_Especialista; set => telefono_Especialista = value; }
        public string Corro_Especialista { get => corro_Especialista; set => corro_Especialista = value; }
        public string Direccion_Especialista { get => direccion_Especialista; set => direccion_Especialista = value; }
        public bool Existe { get => existe; set => existe = value; }

        // set get 2
        public void setId_Especialista(int id_Especialista)
        {
            this.id_Especialista = id_Especialista;
        }

        public void setNombre_Especialista(string nombre_Especialista)
        {
            this.nombre_Especialista = nombre_Especialista;
        }

        public void setTelefono_Especialista(int telefono_Especialista)
        {
            this.telefono_Especialista = telefono_Especialista;
        }

        public void setCorreo_Especialista(string corro_Especialista)
        {
            this.corro_Especialista = corro_Especialista;
        }

        public void setDireccion_Especialista(string direccion_Especialista)
        {
            this.direccion_Especialista = direccion_Especialista;
        }

        public void setExiste(bool existe)
        {
            this.existe = existe;
        }

        public int getId_Especialista()
        {
            return id_Especialista;
        }

        public string getNombre_Especialista()
        {
            return nombre_Especialista;
        }

        public int getTelefono_Especialista()
        {
            return telefono_Especialista;
        }

        public string getCorro_Especialista()
        {
            return corro_Especialista;
        }

        public string getDireccion_Especialista()
        {
            return direccion_Especialista;
        }

        public bool getExiste()
        {
            return existe;
        }



        // constructor vacio
        public EntidadEspecialistas()
        {
            this.Id_Especialista = 0;
            this.Nombre_Especialista = string.Empty;
            this.Telefono_Especialista = 0;
            this.Corro_Especialista = string.Empty;
            this.Direccion_Especialista = string.Empty;
            this.Existe = false;
        }
        // cosntructor con parametros
        public EntidadEspecialistas(int id_Especialista, string nombre_Especialista, int telefono_Especialista, string corro_Especialista, string direccion_Especialista, bool existe)
        {
            this.Id_Especialista = id_Especialista;
            this.Nombre_Especialista = nombre_Especialista;
            this.Telefono_Especialista = telefono_Especialista;
            this.Corro_Especialista = corro_Especialista;
            this.Direccion_Especialista = direccion_Especialista;
            this.Existe = existe;
        }
    }// fin entidad especialistas
}// namespace
