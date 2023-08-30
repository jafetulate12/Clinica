using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    public class EntidadFuncionarios
    {
        // atributos
        private int  id_Funcionario;
        private string  puesto_Funcionario;
        private string nombre_Completo_Funcionario;
        private int telefono_Funcionario;
        private string correo_Funcionario;
        private bool existe;
        // get y set 
        public int Id_Funcionario { get => id_Funcionario; set => id_Funcionario = value; }
        public string Puesto_Funcionario { get => puesto_Funcionario; set => puesto_Funcionario = value; }
        public string Nombre_Completo_Funcionario { get => nombre_Completo_Funcionario; set => nombre_Completo_Funcionario = value; }
        public int Telefono_Funcionario { get => telefono_Funcionario; set => telefono_Funcionario = value; }
        public string Correo_Funcionario { get => correo_Funcionario; set => correo_Funcionario = value; }
        public bool Existe { get => existe; set => existe = value; }

        // constructor parametros
        public EntidadFuncionarios(int id_Funcionario, string puesto_Funcionario, string nombre_Completo_Funcionario, int telefono_Funcionario, string correo_Funcionario, bool existe)
        {
            this.Id_Funcionario = id_Funcionario;
            this.Puesto_Funcionario = puesto_Funcionario;
            this.Nombre_Completo_Funcionario = nombre_Completo_Funcionario;
            this.Telefono_Funcionario = telefono_Funcionario;
            this.Correo_Funcionario = correo_Funcionario;
            this.Existe = existe;
        }// fin construc parametros
         // constructor vacio
        public EntidadFuncionarios()
        {
            Id_Funcionario = 0;
            Puesto_Funcionario = string.Empty;
            Nombre_Completo_Funcionario = string.Empty;
            Telefono_Funcionario = 0;
            Correo_Funcionario = string.Empty;
            Existe = false;
        }// fin construc vacio

        // get 2
        public int GetId_Funcionario()
        {
            return id_Funcionario;
        }

        public string GetPuesto_Funcionario()
        {
            return puesto_Funcionario;
        }

        public string GetNombre_Completo_Funcionario()
        {
            return nombre_Completo_Funcionario;
        }

        public int GetTelefono_Funcionario()
        {
            return telefono_Funcionario;
        }

        public string GetCorreo_Funcionario()
        {
            return correo_Funcionario;
        }

        public bool GetExiste()
        {
            return existe;
        }
        // fin get 2
        // set 2

        // fin set2
        public void SetId_Funcionario(int id_Funcionario)
        {
            this.id_Funcionario = id_Funcionario;
        }

        public void SetPuesto_Funcionario(string puesto_Funcionario)
        {
            this.puesto_Funcionario = puesto_Funcionario;
        }

        public void SetNombre_Completo_Funcionario(string nombre_Completo_Funcionario)
        {
            this.nombre_Completo_Funcionario = nombre_Completo_Funcionario;
        }

        public void SetTelefono_Funcionario(int telefono_Funcionario)
        {
            this.telefono_Funcionario = telefono_Funcionario;
        }

        public void SetCorreo_Funcionario(string correo_Funcionario)
        {
            this.correo_Funcionario = correo_Funcionario;
        }

        public void SetExiste(bool existe)
        {
            this.existe = existe;
        }
    }//fin entidad funcionarios
}// fin namespace
