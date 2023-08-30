using CapaEntidades;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CapaInterfaz
{
    public partial class frmBuscarFuncionario : Form
    {
        public frmBuscarFuncionario()
        {
            InitializeComponent();
        }
        // variables globales
        public event EventHandler Aceptar;
        int vgn_id_Funcionario;

        private void CargarListaDataSet(string condicion = "", string orden = "")
        {
            BLFuncionarios logica = new BLFuncionarios(Configuracion.getConnectionString);
            DataSet DSFuncionario;
            try
            {
                DSFuncionario = logica.ListarClientes(condicion, orden);
                grdVista.DataSource = DSFuncionario;
                grdVista.DataMember = DSFuncionario.Tables["Funcionarios"].TableName;

            }
            catch (Exception)
            {
                MessageBox.Show("Ocurio un error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmBuscarFuncionario_Load(object sender, EventArgs e)
        {
            try
            {
                CargarListaDataSet();
            }
            catch (Exception)
            {

                throw;
            }
        }// fin load

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string condicion = string.Empty;

            try
            {
                if (!string.IsNullOrEmpty(txtNombre.Text))
                {
                    condicion = string.Format("NOMBRE_COMPLETO_FUNCIONARIO like '%{0}%'", txtNombre.Text.Trim());
                }
                else
                {
                    MessageBox.Show("Debe escribir el nombre a buscar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    txtNombre.Focus();
                }
                CargarListaDataSet(condicion);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }// fin btn buscar

        private void seleccionar()
        {
            if (grdVista.SelectedRows.Count > 0)
            {
                vgn_id_Funcionario = (int)grdVista.SelectedRows[0].Cells[0].Value;
                Aceptar(vgn_id_Funcionario, null);
                Close();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            seleccionar();
        }// fin seleccionar

        private void grdVista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Aceptar(-1, null);
            Close();
        }
    }// fin frm buscar funcionarios
}// fin namespace
