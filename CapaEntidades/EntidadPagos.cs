using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
   public  class EntidadPagos
    {
        

        public int id_Factura { get; set; }
        public int id_Funcionario { get; set; }
        public double monto_Pago { get; set; }
        public DateTime? fecha_Pago  { get; set; }
        public string tipo_Pago { get; set; }
        public int id_Paciente { get; set; }
        public bool existe { get; set; }

        public EntidadPagos(int id_Factura, int id_Funcionario, double monto_Pago, DateTime? fecha_Pago, string tipo_Pago, int id_Paciente, bool existe)
        {
            this.id_Factura = id_Factura;
            this.id_Funcionario = id_Funcionario;
            this.monto_Pago = monto_Pago;
            this.fecha_Pago = fecha_Pago;
            this.tipo_Pago = tipo_Pago;
            this.id_Paciente = id_Paciente;
            this.existe = existe;
        }

        public EntidadPagos()
        {
            id_Factura = 0;
            id_Funcionario = 0;
            monto_Pago = 0.0;
            fecha_Pago = Convert.ToDateTime("01/01/1900");
            tipo_Pago = string.Empty;
            id_Paciente = 0;
            existe = false;
        }


        public void setId_Factura(int idFactura) { this.id_Factura = idFactura; }
        public void setId_Funcionario(int idFuncionario) { this.id_Funcionario = idFuncionario; }
        public void setMonto_Pago(double montoPago) { this.monto_Pago = montoPago; }
        public void setFecha_Pago(DateTime? fechaPago) { this.fecha_Pago = fechaPago; }
        public void setTipo_Pago(string tipoPago) { this.tipo_Pago = tipoPago; }
        public void setId_Paciente(int idPaciente) { this.id_Paciente = idPaciente; }
        public void setExiste(bool existe) { this.existe = existe; }

        public int getId_Factura() { return id_Factura; }
        public int getId_Funcionario() { return id_Funcionario; }
        public double getMonto_Pago() { return monto_Pago; }
        public DateTime? getFecha_Pago() { return fecha_Pago; }
        public string getTipo_Pago() { return tipo_Pago; }
        public int getId_Paciente() { return id_Paciente; }
        public bool getExiste() { return existe; }



    }// fin entidad pagos
}// fin namespace
