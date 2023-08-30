using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CapaLogica;
using CapaEntidades;

namespace CapaInterfaz
{
    public partial class frmAministrarHistorial : Form
    {
        public frmAministrarHistorial()
        {
            InitializeComponent();
        }

        //Variable Global
        frmBuscarPaciente formularioPaciente;
        frmBuscarMedicamento formularioMedicamento;
        frmBuscarDiagnostico formularioDiagnostico;

        //variable global para un cliente
        EntidadHistorial HistorialRegistrado;

        private EntidadHistorial GenerarEntidadHistorial()
        {
            EntidadHistorial historial = new EntidadHistorial();
            if (!string.IsNullOrEmpty(txtIdHistorial.Text))
            {
                historial = HistorialRegistrado;
            }
            else
            {
                historial = new EntidadHistorial();
            }
            historial.setIdPaciente(Convert.ToInt32(txtIdPaciente.Text));
            historial.setIdMedicamento(Convert.ToInt32(txtIdMedicamento.Text));
            historial.setIdDiagnostico(Convert.ToInt32(txtIdDiagnostico.Text));
            return historial;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            BLHistorial logica = new BLHistorial(Configuracion.getConnectionString);
            EntidadHistorial historial;
            int resultado;
            string Mensaje = string.Empty;

            try
            {
                if (!string.IsNullOrEmpty(txtIdPaciente.Text) && !string.IsNullOrEmpty(txtIdMedicamento.Text) && !string.IsNullOrEmpty(txtIdDiagnostico.Text))
                {
                    historial = GenerarEntidadHistorial();
                    if (!historial.Existe)
                    {
                        resultado = logica.Insertar(historial);
                        Mensaje = " Historial Insertado correctamente";
                    }
                    else
                    {
                        resultado = logica.ModificarHistorial(historial);
                        Mensaje = " Historial modificado correctamente";

                    }
                    Limpiar();
                    MessageBox.Show(Mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void Limpiar()
        {
            txtIdHistorial.Text = string.Empty;
            txtIdMedicamento.Text = string.Empty;
            txtIdPaciente.Text = string.Empty;
            txtIdDiagnostico.Text = string.Empty;
        }

        //cargar la lista de clientes con un DataSet
        private void CargarListaDataSet(string condicion = "", string orden = "")
        {
            BLHistorial logica = new BLHistorial(Configuracion.getConnectionString);
            DataSet DSHistorial;
            try
            {
                DSHistorial = logica.ListarHistorial(condicion, orden);
                grdListaEspecialista.DataSource = DSHistorial;
                grdListaEspecialista.DataMember = DSHistorial.Tables["Historial"].TableName;

            }
            catch (Exception)
            {
                MessageBox.Show("Ocurio un error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarHistorial(int id)
        {
            EntidadHistorial historial = new EntidadHistorial();
            BLHistorial traerHistorial = new BLHistorial(Configuracion.getConnectionString);
            //TODO revisar el devolver de la fecha
            try
            {
                historial = traerHistorial.ObtenerHistorial(id);
                if (historial != null)
                {
                    txtIdHistorial.Text = historial.IdHistorial.ToString();
                    txtIdPaciente.Text = historial.IdPaciente.ToString();
                    txtIdMedicamento.Text = historial.IdMedicamento.ToString();
                    txtIdDiagnostico.Text = historial.IdDiagnosticoe.ToString();
                    HistorialRegistrado = historial;
                }
                else
                {
                    MessageBox.Show("El  Historial no esta en la base de datos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CargarListaDataSet();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void Aceptar(object id, EventArgs e)
        {
            try
            {
                int idHistorial = (int)id;
                if (idHistorial != -1)
                {
                    CargarHistorial(idHistorial);
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

        private void grdListaEspecialista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = 0;
            try
            {
                //Recuperar el id de DGV
                id = (int)grdListaEspecialista.SelectedRows[0].Cells[0].Value;
                CargarHistorial(id);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EntidadHistorial historial;
            int resultado;
            BLHistorial logica = new BLHistorial(Configuracion.getConnectionString);
            try
            {
                if (!string.IsNullOrEmpty(txtIdHistorial.Text))
                {
                    historial = logica.ObtenerHistorial(int.Parse(txtIdHistorial.Text));
                    if (historial != null)
                    {
                        //resultado = logica.EliminarConSP(cliente);
                        //MessageBox.Show(logica.Mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        resultado = logica.EliminarHistorial(historial);
                        MessageBox.Show("Eliminado ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        CargarListaDataSet();
                    }
                    else
                    {
                        MessageBox.Show(" Historial no existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        CargarListaDataSet();
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un  Historial", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // llamado a otros formularios

        private void CargarPaciente(int id)
        {
            EntidadPacientes paciente = new EntidadPacientes();
            BLPacientes traePACIENTE = new BLPacientes(Configuracion.getConnectionString);

            try
            {
                paciente = traePACIENTE.obtenerPaciente(id);
                if (paciente != null)
                {
                    txtIdPaciente.Text = paciente.IdPaciente.ToString();

                }
                else
                {
                    MessageBox.Show("El  Historial no esta en la base de datos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CargarListaDataSet();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AceptarPaciente(object id, EventArgs e)
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

        // llamado a otros formulkario
        private void CargarMedicamento(int id)
        {
            EntidadMedicamentos medicamento = new EntidadMedicamentos();
            BLMedicamentos traeMedicamento = new BLMedicamentos (Configuracion.getConnectionString);

            try
            {
                medicamento = traeMedicamento.ObtenerMedicamento(id);
                if (medicamento != null)
                {
                    txtIdMedicamento.Text = medicamento.IdMedicamento.ToString();

                }
                else
                {
                    MessageBox.Show("El  Historial no esta en la base de datos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CargarListaDataSet();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AceptarMedicamento(object id, EventArgs e)
        {
            try
            {
                int idMedicamento = (int)id;

                if (idMedicamento != -1)
                {
                    CargarMedicamento(idMedicamento);
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

        // LLAMADO A OTROS FORMULARIOS
        private void CargarDiagnostico(int id)
        {
            EntidadDiagnostico diagnostico = new EntidadDiagnostico();
            BLDiagnostico traeDiagnostico = new BLDiagnostico(Configuracion.getConnectionString);

            try
            {
                diagnostico = traeDiagnostico.ObtenerDiagnostico(id);
                if (diagnostico != null)
                {
                    txtIdDiagnostico.Text = diagnostico.Id_Diagnostico.ToString();

                }
                else
                {
                    MessageBox.Show("El  Historial no esta en la base de datos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CargarListaDataSet();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AceptarDiagnostico(object id, EventArgs e)
        {
            try
            {
                int idDiagnostico = (int)id;

                if (idDiagnostico != -1)
                {
                    CargarDiagnostico(idDiagnostico);
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

        //private void btnBusIdEsp_Click(object sender, EventArgs e)
       // {

       // }

        private void btnBusIdPac_Click(object sender, EventArgs e)
        {
            formularioPaciente = new frmBuscarPaciente();
            //Especificar que se va a usar el evento aceptar
            formularioPaciente.Aceptar += new EventHandler(AceptarPaciente);
            formularioPaciente.ShowDialog();
        }

        private void btnBusIdMed_Click(object sender, EventArgs e)
        {
            formularioMedicamento = new frmBuscarMedicamento();
            //Especificar que se va a usar el evento aceptar
            formularioMedicamento.Aceptar += new EventHandler(AceptarMedicamento);
            formularioMedicamento.ShowDialog();

        }

        private void btnBusIdDiag_Click(object sender, EventArgs e)
        {
            formularioDiagnostico = new frmBuscarDiagnostico();
            //Especificar que se va a usar el evento aceptar
            formularioDiagnostico.Aceptar += new EventHandler(AceptarDiagnostico);
            formularioDiagnostico.ShowDialog();
        }

        private void frmAministrarHistorial_Load(object sender, EventArgs e)
        {
            CargarListaDataSet();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }// frm fin
}// namespace
