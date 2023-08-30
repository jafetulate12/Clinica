using System;
using System.Windows.Forms;
using CapaLogica;
using CapaEntidades;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CapaInterfaz
{
    public partial class frmAdministrarPagos : Form
    {
        public frmAdministrarPagos()
        {
            InitializeComponent();
        }

        frmBuscarPaciente formularioPaciente;

        frmBuscarFuncionario formularioFuncionario;

        EntidadPagos PagoRegistrado;

        //Generar la entidad Cliente
        private EntidadPagos GenerarEntidadPago()
        {
            EntidadPagos pago = new EntidadPagos();
            if (!string.IsNullOrEmpty(txtIDFactura.Text))
            {
                pago = PagoRegistrado;
            }
            else
            {
                pago = new EntidadPagos();
            }
            pago.setId_Funcionario(Convert.ToInt32(txtIdFuncionario.Text));
            pago.setMonto_Pago(Convert.ToInt32(txtMontoPago.Text));
            pago.setMonto_Pago(Convert.ToDouble(txtMontoPago.Text));
            pago.setFecha_Pago(Convert.ToDateTime(dtpFechaPago.Text));
            pago.setTipo_Pago(cboTipo.Text);
            pago.setId_Paciente(Convert.ToInt32(txtPaciente.Text));
            return pago;
        }


        private void Limpiar()
        {
            txtIDFactura.Text = string.Empty;
            txtIdFuncionario.Text = string.Empty;
            txtMontoPago.Text = string.Empty;
            dtpFechaPago.Text = string.Empty;
            cboTipo.SelectedIndex= 0;
            txtPaciente.Text = string.Empty;

        }

        //cargar la lista de clientes con un DataSet
        private void CargarListaDataSet(string condicion = "", string orden = "")
        {
            BLPagos logica = new BLPagos(Configuracion.getConnectionString);
            DataSet DSPago;
            try
            {
                DSPago = logica.ListarPago(condicion, orden);
                grdPagos.DataSource = DSPago;
                grdPagos.DataMember = DSPago.Tables["Pagos"].TableName;

            }
            catch (Exception)
            {
                MessageBox.Show("Ocurio un error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Cargar los datos del cliente por medio del id
        private void CargarPagos(int id)
        {
            EntidadPagos pago = new EntidadPagos();
            BLPagos traerCliente = new BLPagos(Configuracion.getConnectionString);

            try
            {
                pago = traerCliente.ObtenerPago(id);
                if (pago != null)
                {
                    txtIDFactura.Text = pago.id_Factura.ToString();
                    txtIdFuncionario.Text = pago.id_Funcionario.ToString();
                    txtMontoPago.Text = pago.monto_Pago.ToString();
                    dtpFechaPago.Value = (DateTime)pago.fecha_Pago;
                    cboTipo.SelectedIndex = pago.tipo_Pago.Length;
                    txtPaciente.Text = pago.id_Paciente.ToString();


                }
                else
                {
                    MessageBox.Show("El PAGO no esta en la base de datos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CargarListaDataSet();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Aceptar(object id, EventArgs e)
        {
            try
            {
                int idPago = (int)id;
                if (idPago != -1)
                {
                    CargarPagos(idPago);
                }
                else
                {
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            BLPagos logica = new BLPagos(Configuracion.getConnectionString);
            EntidadPagos pago;
            int resultado;
            string Mensaje = string.Empty;

            try
            {
                if (string.IsNullOrEmpty(txtIDFactura.Text) && !string.IsNullOrEmpty(txtIdFuncionario.Text) && !string.IsNullOrEmpty(txtMontoPago.Text) && !string.IsNullOrEmpty(txtPaciente.Text))
                {
                    pago = GenerarEntidadPago();
                    if (!pago.existe)
                    {
                        resultado = logica.Insertar(pago);
                        Mensaje = "PAGO Insertado correctamente";
                    }
                    else
                    {
                        resultado = logica.ModificarPago(pago);
                        Mensaje = "PAGO modificado correctamente";

                    }
                    Limpiar();
                    MessageBox.Show(Mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarListaDataSet();
                }
                else
                {
                    MessageBox.Show("Datos Obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void btnEliminar_Click(object sender, EventArgs e)
        //{

        //}

        private void grdPagos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = 0;
            try
            {
                //Recuperar el id de DGV
                id = (int)grdPagos.SelectedRows[0].Cells[0].Value;
                CargarPagos(id);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmAdministrarPagos_Load(object sender, EventArgs e)
        {
            try
            {
                CargarListaDataSet();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // llamado a otros formularios

        private void CargarPaciente(int id)
        {
            EntidadPacientes paciente = new EntidadPacientes();
            BLPacientes traePACIENTE = new BLPacientes(Configuracion.getConnectionString);

            try
            {
                paciente = traePACIENTE.obtenerPaciente(id);
                if (paciente != null)
                {
                    txtPaciente.Text = paciente.IdPaciente.ToString();

                }
                else
                {
                    MessageBox.Show("El registro no esta en la base de datos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CargarListaDataSet();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AceptarPaciente(object id, EventArgs e)
        {
            try
            {
                int idPaciente = (int)id;

                if (idPaciente != -1)
                {
                    CargarPaciente(idPaciente);
                }
                else
                {
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarFuncionario(int id)
        {
            EntidadFuncionarios funcionario = new EntidadFuncionarios();
            BLFuncionarios traerFuncionario = new BLFuncionarios(Configuracion.getConnectionString);

            try
            {
                funcionario = traerFuncionario.ObtenerFuncionario(id);
                if (funcionario != null)
                {
                    txtIdFuncionario.Text = funcionario.Id_Funcionario.ToString();

                }
                else
                {
                    MessageBox.Show("El registro no esta en la base de datos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CargarListaDataSet();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AceptaFuncionario(object id, EventArgs e)
        {
            try
            {
                int idFuncionario = (int)id;

                if (idFuncionario != -1)
                {
                    CargarFuncionario(idFuncionario);
                }
                else
                {
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIdFuncionario_Click(object sender, EventArgs e)
        {
            formularioFuncionario = new frmBuscarFuncionario();
            //Especificar que se va a usar el evento aceptar
            formularioFuncionario.Aceptar += new EventHandler(AceptaFuncionario);
            formularioFuncionario.ShowDialog();
        }

        private void btnIdPaciente_Click(object sender, EventArgs e)
        {
            formularioPaciente = new frmBuscarPaciente();
            //Especificar que se va a usar el evento aceptar
            formularioPaciente.Aceptar += new EventHandler(AceptarPaciente);
            formularioPaciente.ShowDialog();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }// frm admin pago
}// namespace
