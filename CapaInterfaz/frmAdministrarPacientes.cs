using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;
using CapaEntidades;

namespace CapaInterfaz
{
    public partial class frmAdministrarPacientes : Form
    {
        // VARIABLE GLOBAL

        frmBuscarPaciente formularioBuscar;

        // variable globala para un paciente
        EntidadPacientes pacienteRegistrado;
        public frmAdministrarPacientes()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private EntidadPacientes GenerarIdentidadPacie()
        {
            EntidadPacientes pacientes;
            if (!string.IsNullOrEmpty(txtIdPaciente.Text))
            {
                pacientes = pacienteRegistrado;
            }
            else
            {
                pacientes = new EntidadPacientes();
            }
            pacientes.setCedulaPaciente(txtCedulaPaciente.Text);
            pacientes.setNombrePaciente(txtNombrePaciente.Text);
            pacientes.setTelefonoPaciente(Convert.ToInt32(txtTelefonoPaciente.Text));
            pacientes.setCorreoPaciente(txtCorreoPaciente.Text);
            pacientes.setDireccionPacientes(txtDireccionPaciente.Text);
            return pacientes;
        }// FIN GENERAR ENTIDAD
        private void CargarPaciente(int id)
        {
            EntidadPacientes pacientes = new EntidadPacientes();
            BLPacientes traerPacientes = new BLPacientes(Configuracion.getConnectionString);
            try
            {
                pacientes = traerPacientes.obtenerPaciente(id);
                if (pacientes != null)
                {
                    txtIdPaciente.Text = pacientes.IdPaciente.ToString();
                    txtCedulaPaciente.Text = pacientes.CedulaPaciente;
                    txtNombrePaciente.Text = pacientes.NombrePaciente;
                    txtTelefonoPaciente.Text = pacientes.TelefonoPaciente.ToString();
                    txtCorreoPaciente.Text = pacientes.CorrreoPaciente;
                    txtDireccionPaciente.Text = pacientes.DireccionPacientes;
                    pacienteRegistrado = pacientes;
                }
                else
                {

                    MessageBox.Show("el paciente no esta", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CargarListaDataSet();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }// cargar lista






        private void Aceptar(object id, EventArgs e)
        {
            try
            {
                int idPaciente = (int)id;
                if (idPaciente != -1)
                {
                    //MessageBox.Show(idCliente.ToString());
                    CargarPaciente(idPaciente);
                }
                else
                {
                    limpiar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }// fin aceptar


        public void limpiar()
        {
            txtIdPaciente.Text = string.Empty;
            txtCedulaPaciente.Text = string.Empty;
            txtNombrePaciente.Text = string.Empty;
            txtTelefonoPaciente.Text = string.Empty;
            txtCorreoPaciente.Text = string.Empty;
            txtDireccionPaciente.Text = string.Empty;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            BLPacientes logica = new BLPacientes(Configuracion.getConnectionString);
            EntidadPacientes pacientes;
            int resultado;
            string mensaje = string.Empty;
            try
            {
                if (!string.IsNullOrEmpty(txtCedulaPaciente.Text) &&
                    !string.IsNullOrEmpty(txtNombrePaciente.Text) &&
                     !string.IsNullOrEmpty(txtTelefonoPaciente.Text) &&
                     !string.IsNullOrEmpty(txtCorreoPaciente.Text) &&
                    !string.IsNullOrEmpty(txtDireccionPaciente.Text))
                {
                    pacientes = GenerarIdentidadPacie();
                    if (!pacientes.Existe)
                    {
                        resultado = logica.insertar(pacientes);
                        mensaje = "paciente insertado de manera correcta";
                    }
                    else
                    {
                        resultado = logica.ModificarPacientes(pacientes);
                        mensaje = "paciente modificado de manera correcta";
                    }

                    limpiar();
                    MessageBox.Show("operacion exitosa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Datos obligatorios", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           CargarListaDataSet();
        }// FIN BTN GUARDAR

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EntidadPacientes pacientes;
            int resultado;
            BLPacientes logica = new BLPacientes(Configuracion.getConnectionString);
            try
            {
                if (!string.IsNullOrEmpty(txtIdPaciente.Text))
                {
                    pacientes = logica.obtenerPaciente(int.Parse(txtIdPaciente.Text));
                    if (pacientes != null)
                    {
                        //resultado = logica.EliminarConSP(cliente);
                        //MessageBox.Show(logica.Mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        resultado = logica.EliminarPaciente(pacientes);
                        MessageBox.Show("Eliminado ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar();
                        CargarListaDataSet();
                    }
                    else
                    {
                        MessageBox.Show("paciente no existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar();
                        CargarListaDataSet();
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un paciente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }// fin btn elimina

        private void CargarListaDataSet(string condicion = "", string orden = "")
        {
            BLPacientes logica = new BLPacientes(Configuracion.getConnectionString);
            DataSet DSPacientes;
            try
            {
                DSPacientes = logica.ListarPacientes(condicion, orden);
                grdListaPacientes.DataSource = DSPacientes;
                grdListaPacientes.DataMember = DSPacientes.Tables["PACIENTES"].TableName;
            }
            catch (Exception)
            {

                MessageBox.Show("ocurrio un error", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }// fin cargar lista

        private void frmAdministrarPacientes_Load(object sender, EventArgs e)
        {
            try
            {
                CargarListaDataSet();
            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }// FIN LOAD ADMIN

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            formularioBuscar = new frmBuscarPaciente();
            // especificar que se bva  ausar el evento aceptar
            formularioBuscar.Aceptar += new EventHandler(Aceptar);
            formularioBuscar.ShowDialog();
        }

        private void grdListaPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = 0;
            try
            {
                // recuperar ID del dgv
                id = (int)grdListaPacientes.SelectedRows[0].Cells[0].Value;
                CargarPaciente(id);
            }
            catch (Exception ex)
            {

                MessageBox.Show( ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }// grd listar paciente

    }// fin  frm pacientes
}// fin namespace
