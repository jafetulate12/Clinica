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
    public partial class frmBuscarCita : Form
    {
        public frmBuscarCita()
        {
            InitializeComponent();
        }

        //Variable global
        public event EventHandler Aceptar;
        int vgn_id_Agenda;

        private void CargarListaDataSet(string condicion = "", string orden = "")
        {
            BLAgenda logica = new BLAgenda(Configuracion.getConnectionString);
            DataSet DSAgenda;
            try
            {
                DSAgenda = logica.ListarAgenda(condicion, orden);
                grdListaAgendaEspe.DataSource = DSAgenda;
                grdListaAgendaEspe.DataMember = DSAgenda.Tables["Agenda"].TableName;

            }
            catch (Exception)
            {
                MessageBox.Show("Ocurio un error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void seleccionar()
        {
            if (grdListaAgendaEspe.SelectedRows.Count > 0)
            {
                vgn_id_Agenda = (int)grdListaAgendaEspe.SelectedRows[0].Cells[0].Value;
                Aceptar(vgn_id_Agenda, null);
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string condicion = string.Empty;

            try
            {
                if (!string.IsNullOrEmpty(txtNombre.Text))
                {
                    condicion = string.Format("FECHA_CITA like '%{0}%'", txtNombre.Text.Trim());
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

        private void grdListaAgendaEspe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionar();
        }

        private void frmBuscarCita_Load(object sender, EventArgs e)
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
    }
}
