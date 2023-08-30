using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CapaEntidades;
using CapaLogica;

namespace CapaInterfaz
{
    public partial class frmBuscarDiagnostico : Form
    {
        public frmBuscarDiagnostico()
        {
            InitializeComponent();
        }

        //Variable global
        public event EventHandler Aceptar;

        int vgn_id_Diagnostico;


        private void CargarListaDataSet(string condicion = "", string orden = "")
        {
            BLDiagnostico logica = new BLDiagnostico(Configuracion.getConnectionString);
            DataSet DSDiagnostico;
            try
            {
                DSDiagnostico = logica.ListarDiagnosticos(condicion, orden);
                grdListaDiagnostico.DataSource = DSDiagnostico;
                grdListaDiagnostico.DataMember = DSDiagnostico.Tables["Diagnosticos"].TableName;

            }
            catch (Exception)
            {
                MessageBox.Show("Ocurio un error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmBuscarDiagnostico_Load(object sender, EventArgs e)
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
                    condicion = string.Format("ID_PACIENTE like '%{0}%'", txtNombre.Text.Trim());
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
            if (grdListaDiagnostico.SelectedRows.Count > 0)
            {
                vgn_id_Diagnostico = (int)grdListaDiagnostico.SelectedRows[0].Cells[0].Value;
                Aceptar(vgn_id_Diagnostico, null);
                Close();
            }
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

       //// private void grdVista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    seleccionar();
       // }

        private void grdListaDiagnostico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionar();
        }
    }
}
