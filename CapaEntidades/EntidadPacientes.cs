using System;

namespace CapaEntidades
{
    public class EntidadPacientes
    {
        // atributos de la clase
        private int id_Paciente;
        private string cedulaPaciente;
        private string nombrePaciente;
        private int telefonoPaciente;
        private string corrreoPaciente;
        private string direccionPaciente;
        private bool existe;
        // constructor vacio
        public EntidadPacientes()
        {
            id_Paciente = 0;
          cedulaPaciente = string.Empty;
            nombrePaciente = string.Empty;
          telefonoPaciente = 0;
          corrreoPaciente = string.Empty;
          direccionPaciente = string.Empty;
          existe = false;
        }// FIN CONSTRUC VACIO


        // cosntructor con parametros
        public EntidadPacientes(int id_Paciente,string cedulaPaciente, string nombrePaciente, int telefonoPaciente, string corrreoPaciente, string direccionPacientes, bool existe)
        {
            this.id_Paciente = id_Paciente;
            this.cedulaPaciente = cedulaPaciente;
            this.nombrePaciente = nombrePaciente;
            this.telefonoPaciente = telefonoPaciente;
            this.corrreoPaciente = corrreoPaciente;
            this.direccionPaciente = direccionPacientes;
            this.existe = existe;
        }// FIN CONSTRUC PARAMETROS
         // get y set
        public int IdPaciente { get => id_Paciente; set => id_Paciente = value; }
        public string CedulaPaciente { get => cedulaPaciente; set => cedulaPaciente = value; }
        public string NombrePaciente { get => nombrePaciente; set => nombrePaciente = value; }
        public int TelefonoPaciente { get => telefonoPaciente; set => telefonoPaciente = value; }
        public string CorrreoPaciente { get => corrreoPaciente; set => corrreoPaciente = value; }
        public string DireccionPacientes { get => direccionPaciente; set => direccionPaciente = value; }
        public bool Existe { get => existe; set => existe = value; }
        // fin get y set
        //set
        public void setIdPaciente(int id_Paciente) { this.id_Paciente = id_Paciente; }
        public void  setCedulaPaciente(string cedulaPaciente) { this.cedulaPaciente = cedulaPaciente; }
        public void setNombrePaciente (string nombrePaciente) { this.nombrePaciente = nombrePaciente; }
        public void setTelefonoPaciente(int telefonoPaciente) { this.telefonoPaciente = telefonoPaciente; }
        public void setCorreoPaciente(string corrreoPaciente) { this.corrreoPaciente = corrreoPaciente; }
        public void setDireccionPacientes(string direccionPaciente) { this.direccionPaciente = direccionPaciente; }
        public void setExiste(bool Existe) { this.Existe = Existe; }
        // fin set
        // get 2
        public int getIdPaciente() { return id_Paciente; }
        public string getCedulaPaciente() { return cedulaPaciente; }
        public string getNombrePaciente() { return nombrePaciente; }
        public int getTelefonoPaciente() { return telefonoPaciente; }
        public string getCorreoPaciente() { return corrreoPaciente; }
        public string getDireccionPacientes() { return direccionPaciente; }
        public bool getExiste() { return existe; } 
       
        // fin get

        // get 2

    }//     FIN ENTIDAD CLIENTES
}// FIN NAMESPACE
