using System;
using System.Windows.Forms;
using CapaLogica;
using CapaEntidades;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace CapaInterfaz
{
    public partial class frmBitacora : Form
    {
        public frmBitacora()
        {
            InitializeComponent();
        }

        private void CargarListaDataSet(string condicion = "", string orden = "")
        {
            BLBitacora logica = new BLBitacora(Configuracion.getConnectionString);
            DataSet DSClientes;
            try
            {
                DSClientes = logica.ListarBitacora(condicion, orden);
                grdBitacora.DataSource = DSClientes;
                grdBitacora.DataMember = DSClientes.Tables["Bitacoras"].TableName;

            }
            catch (Exception)
            {
                MessageBox.Show("Ocurio un error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmBitacora_Load(object sender, EventArgs e)
        {
            CargarListaDataSet();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
