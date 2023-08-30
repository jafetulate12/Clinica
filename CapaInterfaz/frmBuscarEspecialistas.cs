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
    public partial class frmBuscarEspecialistas : Form
    {
        public frmBuscarEspecialistas()
        {
            InitializeComponent();
        }

        //Variable global
        public event EventHandler Aceptar;
        int vgn_id_Especialista;



        private void CargarListaDataSet(string condicion = "", string orden = "")
        {
            BLEspecialistas logica = new BLEspecialistas(Configuracion.getConnectionString);
            DataSet DSClientes;
            try
            {
                DSClientes = logica.ListarEspecialista(condicion, orden);
                grdVista.DataSource = DSClientes;
                grdVista.DataMember = DSClientes.Tables["Especialistas"].TableName;

            }
            catch (Exception)
            {
                MessageBox.Show("Ocurio un error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmBuscarEspecialistas_Load(object sender, EventArgs e)
        {
            try
            {
                CargarListaDataSet();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string condicion = string.Empty;

            try
            {
                if (!string.IsNullOrEmpty(txtNombre.Text))
                {
                    condicion = string.Format("NOMBRE_COMPLETO_ESPECIALISTA like '%{0}%'", txtNombre.Text.Trim());
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
        }

        private void seleccionar()
        {
            if (grdVista.SelectedRows.Count > 0)
            {
                vgn_id_Especialista = (int)grdVista.SelectedRows[0].Cells[0].Value;
                Aceptar(vgn_id_Especialista, null);
                Close();
            }
        }

        private void grdVista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionar();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            seleccionar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Aceptar(-1, null);
            Close();
        }
    }
}
