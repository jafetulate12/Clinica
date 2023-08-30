using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaInterfaz
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void agregarPacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdministrarPacientes frm = new frmAdministrarPacientes();
            frm.Show();

        }

        private void administrarFuncionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFuncionarios frm = new frmFuncionarios();
            frm.Show();
        }

        private void administrarEspecialistasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdministrarEspecialistas frm = new frmAdministrarEspecialistas();
            frm.Show();
        }

        private void agregarEspecilidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdministrarEspecialidad frm = new frmAdministrarEspecialidad();
            frm.Show();
        }

        private void administrarMedcamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdmistrarMedicamentos frm = new frmAdmistrarMedicamentos();
                frm.Show();
        }

        private void administrarDiagnosticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdministrarDiagnostico frm = new frmAdministrarDiagnostico();
            frm.Show();
        }

        private void historialMedicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAministrarHistorial frm = new frmAministrarHistorial();
            frm.Show();
        }

        private void agendaEspecialistaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAdministrarAgendaEspecialista frm = new frmAdministrarAgendaEspecialista();
            frm.Show();
        }

        private void administarCitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCitasAProgramar frm = new frmCitasAProgramar();
            frm.Show();
        }

        private void administrarPagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdministrarPagos frm = new frmAdministrarPagos();
            frm.Show();
        }

        private void mostrarBitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBitacora frm = new frmBitacora();
            frm.Show();
        }
    }// fin frm menu
}// fin namespace
