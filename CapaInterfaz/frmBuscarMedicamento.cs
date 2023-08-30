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
    public partial class frmBuscarMedicamento : Form
    {
        public frmBuscarMedicamento()
        {
            InitializeComponent();
        }

        //Variable global
        public event EventHandler Aceptar;
        int vgn_id_medicamento;


        private void CargarListaDataSet(string condicion = "", string orden = "")
        {
            BLMedicamentos logica = new BLMedicamentos(Configuracion.getConnectionString);
            DataSet DSMedicamento;
            try
            {
                DSMedicamento = logica.ListarMedicamentos(condicion, orden);
                grdListaEspecialista.DataSource = DSMedicamento;
                grdListaEspecialista.DataMember = DSMedicamento.Tables["Medicamentos"].TableName;

            }
            catch (Exception)
            {
                MessageBox.Show("Ocurio un error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void grdListaEspecialista_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string condicion = string.Empty;

            try
            {
                if (!string.IsNullOrEmpty(txtNombre.Text))
                {
                    condicion = string.Format("ID_MEDICAMENTO like '%{0}%'", txtNombre.Text.Trim());
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
            if (grdListaEspecialista.SelectedRows.Count > 0)
            {
                vgn_id_medicamento = (int)grdListaEspecialista.SelectedRows[0].Cells[0].Value;
                Aceptar(vgn_id_medicamento, null);
                Close();
            }
        }



        private void frmBuscarMedicamento_Load(object sender, EventArgs e)
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


    }// frm buscar
}// namespace
