using CapaEntidades;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CapaInterfaz
{
    public partial class frmBuscarEspecialidad : Form
    {
        public frmBuscarEspecialidad()
        {
            InitializeComponent();
        }
        //Variable global
        public event EventHandler Aceptar;

        int vgn_id_Especialidad;

        private void CargarListaDataSet(string condicion = "", string orden = "")
        {
            BLEspecialidad logica = new BLEspecialidad(Configuracion.getConnectionString);
            DataSet DSEspecialidad;
            try
            {
                DSEspecialidad = logica.ListarEspecialidad(condicion, orden);
                grdListaEspecialidad.DataSource = DSEspecialidad;
                grdListaEspecialidad.DataMember = DSEspecialidad.Tables["Especialidades"].TableName;

            }
            catch (Exception)
            {
                MessageBox.Show("Ocurio un error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmBuscarEspecialidad_Load(object sender, EventArgs e)
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
                    condicion = string.Format("NOMBRE_ESPECIALIDAD like '%{0}%'", txtNombre.Text.Trim());
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
            if (grdListaEspecialidad.SelectedRows.Count > 0)
            {
                vgn_id_Especialidad = (int)grdListaEspecialidad.SelectedRows[0].Cells[0].Value;
                Aceptar(vgn_id_Especialidad, null);
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

       // private void grdListaEspecialista_CellContentClick(object sender, DataGridViewCellEventArgs e)
       // {
        //    seleccionar();
       // }

        private void grdListaEspecialidad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionar();
        }
    }
}
