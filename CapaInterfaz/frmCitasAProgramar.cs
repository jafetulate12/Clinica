using System.Windows.Forms;
using CapaLogica;
using CapaEntidades;
using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CapaInterfaz
{
    public partial class frmCitasAProgramar : Form
    {
        public frmCitasAProgramar()
        {
            InitializeComponent();
        }
        // varibles globales

        EntidadCitasAProgramar CitaRegistrada;

        frmBuscarCita formularioBuscarCita;
        frmBuscarFuncionario formularioBuscarFuncio;
        frmBuscarPaciente formularioBuscarPaciente;

        private void Limpiar()
        {
            txtCitaProgramada.Text = string.Empty;
            txtIdCita.Text = string.Empty;
            txtIdFuncionario.Text = string.Empty;
            txtIdPaciente.Text = string.Empty;
        }

        private EntidadCitasAProgramar GenerarEntidadCitaPr()
        {
            EntidadCitasAProgramar cita = new EntidadCitasAProgramar();
            if (!string.IsNullOrEmpty(txtCitaProgramada.Text))
            {
                cita = CitaRegistrada;
            }
            else
            {
                cita = new EntidadCitasAProgramar();
            }
            cita.SetId_Funcionario(Convert.ToInt32(txtIdFuncionario.Text));
            cita.SetId_Cita(Convert.ToInt32(txtIdCita.Text));
            cita.SetId_Paciente(Convert.ToInt32(txtIdPaciente.Text));
            return cita;
        }

        private void CargarListaDataSet(string condicion = "", string orden = "")
        {
            BLCitas logica = new BLCitas(Configuracion.getConnectionString);
            DataSet DSCitas;
            try
            {
                DSCitas = logica.ListarCita(condicion, orden);
                grdCitasProgram.DataSource = DSCitas;
                grdCitasProgram.DataMember = DSCitas.Tables["Citas"].TableName;

            }
            catch (Exception)
            {
                MessageBox.Show("Ocurio un error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void CargarAgenda(int id)
        {
            EntidadAgendaEspecialista agenda = new EntidadAgendaEspecialista();
            BLAgenda traerAgenda = new BLAgenda(Configuracion.getConnectionString);

            try
            {
                agenda = traerAgenda.ObtenerAgenda(id);
                if (agenda != null)
                {
                    txtIdCita.Text = agenda.Id_Citas.ToString();

                }
                else
                {
                    MessageBox.Show("El registro no esta en la base de datos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CargarListaDataSet();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AceptaAgenda(object id, EventArgs e)
        {
            try
            {
                int idAgenda = (int)id;

                if (idAgenda != -1)
                {
                    CargarAgenda(idAgenda);
                }
                else
                {
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void CargarFuncionario(int id)
        {
            EntidadFuncionarios funcionario = new EntidadFuncionarios();
            BLFuncionarios traerFuncionario = new BLFuncionarios(Configuracion.getConnectionString);

            try
            {
                funcionario = traerFuncionario.ObtenerFuncionario(id);
                if (funcionario != null)
                {
                    txtIdFuncionario.Text = funcionario.Id_Funcionario.ToString();

                }
                else
                {
                    MessageBox.Show("El registro no esta en la base de datos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CargarListaDataSet();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AceptaFuncionario(object id, EventArgs e)
        {
            try
            {
                int idFuncionario = (int)id;

                if (idFuncionario != -1)
                {
                    CargarFuncionario(idFuncionario);
                }
                else
                {
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarPaciente(int id)
        {
            EntidadPacientes paciente = new EntidadPacientes();
            BLPacientes traerPaciente = new BLPacientes(Configuracion.getConnectionString);

            try
            {
                paciente = traerPaciente.obtenerPaciente(id);
                if (paciente != null)
                {
                    txtIdPaciente.Text = paciente.IdPaciente.ToString();

                }
                else
                {
                    MessageBox.Show("El registro no esta en la base de datos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CargarListaDataSet();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AceptaPaciente(object id, EventArgs e)
        {
            try
            {
                int idPaciente = (int)id;

                if (idPaciente != -1)
                {
                    CargarPaciente(idPaciente);
                }
                else
                {
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnCitas_Click(object sender, EventArgs e)
        {
            formularioBuscarCita = new frmBuscarCita();
            //Especificar que se va a usar el evento aceptar
            formularioBuscarCita.Aceptar += new EventHandler(AceptaAgenda);
            formularioBuscarCita.ShowDialog();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            formularioBuscarFuncio = new frmBuscarFuncionario();
            //Especificar que se va a usar el evento aceptar
            formularioBuscarFuncio.Aceptar += new EventHandler(AceptaFuncionario);
            formularioBuscarFuncio.ShowDialog();
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            formularioBuscarPaciente = new frmBuscarPaciente();
            //Especificar que se va a usar el evento aceptar
            formularioBuscarPaciente.Aceptar += new EventHandler(AceptaPaciente);
            formularioBuscarPaciente.ShowDialog();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            BLCitas logica = new BLCitas(Configuracion.getConnectionString);
            EntidadCitasAProgramar cita;
            int resultado;
            string Mensaje = string.Empty;

            try
            {
                if (string.IsNullOrEmpty(txtCitaProgramada.Text))
                {
                    cita = GenerarEntidadCitaPr();
                    if (!cita.Existe)
                    {
                        resultado = logica.Insertar(cita);////
                        MessageBox.Show(logica.Mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                    else
                    {
                        // resultado = logica.(cliente);
                        MessageBox.Show("--", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Question);

                    }
                    Limpiar();
                    CargarListaDataSet();
                }
                else
                {
                    MessageBox.Show("Datos Obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EntidadCitasAProgramar cita;
            int resultado;
            BLCitas logica = new BLCitas(Configuracion.getConnectionString);
            try
            {
                if (!string.IsNullOrEmpty(txtCitaProgramada.Text))
                {
                    cita = logica.ObtenerCita(int.Parse(txtCitaProgramada.Text));
                    if (cita != null)
                    {

                        resultado = logica.EliminarCita(cita);
                        MessageBox.Show("Cita eliminada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        CargarListaDataSet();
                    }
                    else
                    {
                        MessageBox.Show("No hay registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        CargarListaDataSet();
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grdCitasProgram_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = 0;
            try
            {
                //Recuperar el id de DGV
                id = (int)grdCitasProgram.SelectedRows[0].Cells[0].Value;
                CargarCita(id);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void CargarCita(int id)
        {
            EntidadCitasAProgramar cita = new EntidadCitasAProgramar();
            BLCitas traerCliente = new BLCitas(Configuracion.getConnectionString);

            try
            {
                cita = traerCliente.ObtenerCita(id);
                if (cita != null)
                {
                    txtCitaProgramada.Text = cita.Cita_A_Programar.ToString();
                    txtIdFuncionario.Text = cita.Id_Funcionario.ToString();
                    txtIdCita.Text = cita.Id_Cita.ToString();
                    txtIdPaciente.Text = cita.Id_Paciente.ToString();
                    CitaRegistrada = cita;
                }
                else
                {
                    MessageBox.Show("El registro no esta en la base de datos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CargarListaDataSet();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }// fin frm

        private void frmCitasAProgramar_Load(object sender, EventArgs e)
        {
            CargarListaDataSet();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
             Close();
        }
    }
}// fin namespace
