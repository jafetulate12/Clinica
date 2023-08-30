using System;
using System.Windows.Forms;
using CapaLogica;
using CapaEntidades;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CapaInterfaz
{
    public partial class frmAdministrarAgendaEspecialista : Form
    {
        public frmAdministrarAgendaEspecialista()
        {
            InitializeComponent();
        }

        frmBuscarEspecialistas formularioBuscarEsp;

        EntidadAgendaEspecialista AgendaRegistrada;


        frmBuscarEspecialidad formularioBuscarEspecialidad;




        private EntidadAgendaEspecialista GenerarAgendaEs()
        {
            EntidadAgendaEspecialista Agenda = new EntidadAgendaEspecialista();
            if (!string.IsNullOrEmpty(txtIDCitas.Text))
            {
                Agenda = AgendaRegistrada;
            }
            else
            {
                Agenda = new EntidadAgendaEspecialista();
            }
            // agrega 30 minutos
            TimeSpan horaInicio = dtpHoraInicio.Value.TimeOfDay;
            TimeSpan horaFinal = horaInicio.Add(TimeSpan.FromMinutes(30));
            // Establecer los milisegundos en cero
            horaInicio = new TimeSpan(horaInicio.Hours, horaInicio.Minutes, horaInicio.Seconds);
            horaFinal = new TimeSpan(horaFinal.Hours, horaFinal.Minutes, horaFinal.Seconds);
            Agenda.setId_Especialidad(Convert.ToInt32(txtEspecialidad.Text));
            Agenda.setId_Especialista(Convert.ToInt32(txtIdEspecialista.Text));
            Agenda.setHora_inicio(horaInicio);
            Agenda.setHora_Final(horaFinal);
            Agenda.setFecha_Cita(dtpFechaCita.Value);

            return Agenda;
        }

        public void Limpiar()
        {

            txtIDCitas.Text = string.Empty;
            txtIdEspecialista.Text = string.Empty;
            TimeSpan horaActual = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            DateTime fechaHoraActual = DateTime.Now;
            DateTime fechaActual = fechaHoraActual.Date;
            horaActual = fechaHoraActual.TimeOfDay;
            DateTime horaFechaActual = fechaActual.Add(horaActual);
            dtpHoraInicio.Value = horaFechaActual;
            dtpHoraFinal.Value = horaFechaActual.AddMinutes(30);
            dtpFechaCita.Value = DateTime.Now;

        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            BLAgenda logica = new BLAgenda(Configuracion.getConnectionString);
            EntidadAgendaEspecialista agenda;
            int resultado;
            string Mensaje = string.Empty;

            try
            {
                if (!string.IsNullOrEmpty(txtIdEspecialista.Text) && !string.IsNullOrEmpty(txtEspecialidad.Text))
                {
                    agenda = GenerarAgendaEs();
                    if (!agenda.Existe)
                    {
                        resultado = logica.Insertar(agenda);////
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

        private void btnBusEspecialista_Click(object sender, EventArgs e)
        {
            formularioBuscarEsp = new frmBuscarEspecialistas();
            //Especificar que se va a usar el evento aceptar
            formularioBuscarEsp.Aceptar += new EventHandler(AceptarEspecialista);
            formularioBuscarEsp.ShowDialog();
        }





        // LLAMADO A OTROS FORMULARIOS
        private void CargarEspecialista (int id)
        {
            EntidadEspecialistas Especialista = new EntidadEspecialistas();
            BLEspecialistas traerEspecialista= new BLEspecialistas(Configuracion.getConnectionString);

            try
            {
                Especialista = traerEspecialista.ObtenerEspecialista(id);
                if (Especialista != null)
                {
                    txtIdEspecialista.Text = Especialista.Id_Especialista.ToString();

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

        private void AceptarEspecialista(object id, EventArgs e)
        {
            try
            {
                int idEspecialista = (int)id;

                if (idEspecialista != -1)
                {
                    CargarEspecialista(idEspecialista);
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

        private void btnBusEspecialidad_Click(object sender, EventArgs e)
        {
            formularioBuscarEspecialidad = new frmBuscarEspecialidad();
            //Especificar que se va a usar el evento aceptar
            formularioBuscarEspecialidad.Aceptar += new EventHandler(AceptarEspecialidad);
            formularioBuscarEspecialidad.ShowDialog();
        }

        private void CargarEspecialidad(int id)
        {
            EntidadEspecialidad especialidad = new EntidadEspecialidad();
            BLEspecialidad traerEspecialidad = new BLEspecialidad(Configuracion.getConnectionString);

            try
            {
                especialidad = traerEspecialidad.ObtenerEspecialidad(id);
                if (especialidad != null)
                {
                    txtEspecialidad.Text = especialidad.Id_Especialidad.ToString();

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

        private void AceptarEspecialidad(object id, EventArgs e)
        {
            try
            {
                int idEspecialidad = (int)id;

                if (idEspecialidad != -1)
                {
                    CargarEspecialidad(idEspecialidad);
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        //
       private void btnEliminar_Click(object sender, EventArgs e)
        { 
        }
        //
        private void grdListaAgendaEspe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = 0;
            try
            {
                //Recuperar el id de DGV
                id = (int)grdListaAgendaEspe.SelectedRows[0].Cells[0].Value;
                CargarAgenda(id);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    txtIDCitas.Text = agenda.Id_Citas.ToString();
                    txtIdEspecialista.Text = agenda.Id_Especialista.ToString();
                    txtEspecialidad.Text = agenda.Id_Especialidad.ToString();
                    dtpHoraInicio.Value= DateTime.Today+agenda. Hora_inicio;
                    dtpHoraFinal.Value = DateTime.Today + agenda.Hora_Final;
                    dtpFechaCita.Value = (DateTime)agenda.Fecha_Cita;
                    AgendaRegistrada = agenda;

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

        private void frmAdministrarAgendaEspecialista_Load(object sender, EventArgs e)
        {
            try
            {
                CargarListaDataSet();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            EntidadAgendaEspecialista agenda;
            int resultado;
            BLAgenda logica = new BLAgenda(Configuracion.getConnectionString);
            try
            {
                if (!string.IsNullOrEmpty(txtIDCitas.Text))
                {
                    agenda = logica.ObtenerAgenda(int.Parse(txtIDCitas.Text));
                    if (agenda != null)
                    {
                        //resultado = logica.EliminarConSP(cliente);
                        //MessageBox.Show(logica.Mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        resultado = logica.EliminarAgenda(agenda);
                        MessageBox.Show("Eliminado ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        CargarListaDataSet();
                    }
                    else
                    {
                        MessageBox.Show("registro no existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }// final
}// frn namespace
