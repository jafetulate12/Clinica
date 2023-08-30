using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CapaLogica;
using CapaEntidades;

namespace CapaInterfaz
{
    public partial class frmBuscarPaciente : Form
    {
        public frmBuscarPaciente()
        {
            InitializeComponent();
        }
        // variable global del evento handler para enviar valores
        public event EventHandler Aceptar;
        // variable global del id cliente para acecedera a todos los datos
        int vgn_id_Paciente;

        private void CargarListaDataSet(string condicion = "", string orden = "")
        {
            BLPacientes logica = new BLPacientes(Configuracion.getConnectionString);
            DataSet DSPacientes;
            try
            {
                DSPacientes = logica.ListarPacientes(condicion, orden);
                grdListaPacientes.DataSource = DSPacientes;
                grdListaPacientes.DataMember = DSPacientes.Tables["Pacientes"].TableName;
            }
            catch (Exception)
            {

                MessageBox.Show("ocurrio un error", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }// fin cargar lista

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string condicion = string.Empty;
            try
            {
                if (!string.IsNullOrEmpty(txtNombrePacienteB.Text))
                {
                    condicion = string.Format("NOMBRE_COMPLETO_PACIENTE like '%{0}%'", txtNombrePacienteB.Text.Trim());
                }
                else
                {
                    MessageBox.Show("escirbir el nombre a buscar", "error", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    txtNombrePacienteB.Focus();
                }
                CargarListaDataSet(condicion);
            }
            catch (Exception )
            {

                MessageBox.Show("no entro a el if", "error", MessageBoxButtons.OK, MessageBoxIcon.Question);

            }
        }// FIN BTN BUSCAR

        private void frmBuscarPaciente_Load(object sender, EventArgs e)
        {
            CargarListaDataSet();
        }// cargar del formulario

        private void seleccionar()
        {
            if (grdListaPacientes.SelectedRows.Count > 0)
            {
                vgn_id_Paciente = (int)grdListaPacientes.SelectedRows[0].Cells[0].Value;
                Aceptar(vgn_id_Paciente, null);
                Close();
            }
        }// fin seleccionar

        private void grdListaPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionar();
        }// fin  selecionar del data griw vie

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            seleccionar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Aceptar(null, null);
            Close();
        }
    }// fin frm buscar
}// fin namespace
