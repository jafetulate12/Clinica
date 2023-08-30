using System;
using System.Windows.Forms;
using CapaLogica;
using CapaEntidades;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CapaInterfaz
{
    public partial class frmAdministrarEspecialidad : Form
    {
        public frmAdministrarEspecialidad()
        {
            InitializeComponent();
        }
        //Variable Global
        frmBuscarEspecialidad formularioBuscar;

        //variable global para un cliente
        EntidadEspecialidad especialidadRegistrada;

        private EntidadEspecialidad GenerarEntidadEspecialidad()
        {
            EntidadEspecialidad especialidad = new EntidadEspecialidad();
            if (!string.IsNullOrEmpty(txtIdEspecialidad.Text))
            {
                especialidad = especialidadRegistrada;
            }
            else
            {
                especialidad= new EntidadEspecialidad();
            }
            especialidad.setNombre_Especialidad(txtNombreEspecialidad.Text);
            especialidad.setDescripcion_Especialidad(txtDescripcionEspecialidad.Text);
            return especialidad;
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EntidadEspecialidad especialidad;
            int resultado;
            BLEspecialidad logica = new BLEspecialidad(Configuracion.getConnectionString);
            try
            {
                if (!string.IsNullOrEmpty(txtIdEspecialidad.Text))
                {
                    especialidad = logica.ObtenerEspecialidad(int.Parse(txtIdEspecialidad.Text));
                    if (especialidad != null)
                    {
                        //resultado = logica.EliminarConSP(cliente);
                        //MessageBox.Show(logica.Mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        resultado = logica.EliminarEspecialidad(especialidad);
                        MessageBox.Show("Eliminado ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        CargarListaDataSet();
                    }
                    else
                    {
                        MessageBox.Show("La Especialidad no existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        CargarListaDataSet();
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una Especialidad", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            BLEspecialidad logica = new BLEspecialidad(Configuracion.getConnectionString);
            EntidadEspecialidad especialidad;
            int resultado;
            string Mensaje = string.Empty;

            try
            {
                if (!string.IsNullOrEmpty(txtNombreEspecialidad.Text) && !string.IsNullOrEmpty(txtDescripcionEspecialidad.Text))
                {
                    especialidad = GenerarEntidadEspecialidad();
                    if (!especialidad.Existe)
                    {
                        resultado = logica.Insertar(especialidad);
                        Mensaje = "Especialidad Insertada correctamente";
                    }
                    else
                    {
                        resultado = logica.ModificarEspecialidad(especialidad);
                        Mensaje = "Especialidad modificada correctamente";

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
            txtIdEspecialidad.Text = string.Empty;
            txtNombreEspecialidad.Text = string.Empty;
            txtDescripcionEspecialidad.Text = string.Empty;
            txtNombreEspecialidad.Focus();
        }

        private void CargarListaDataSet(string condicion = "", string orden = "")
        {
            BLEspecialidad logica = new BLEspecialidad(Configuracion.getConnectionString);
            DataSet DSEspecialidad;
            try
            {
                DSEspecialidad = logica.ListarEspecialidad(condicion, orden);
                grdListaEspecialista.DataSource = DSEspecialidad;
                grdListaEspecialista.DataMember = DSEspecialidad.Tables["Especialidades"].TableName;

            }
            catch (Exception)
            {
                MessageBox.Show("Ocurio un error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarEspecialidad(int id)
        {
            EntidadEspecialidad especialidad = new EntidadEspecialidad();
            BLEspecialidad traeEspecialidad = new BLEspecialidad(Configuracion.getConnectionString);

            try
            {
                especialidad = traeEspecialidad.ObtenerEspecialidad(id);
                if (especialidad != null)
                {
                    txtIdEspecialidad.Text = especialidad.Id_Especialidad.ToString();
                    txtNombreEspecialidad.Text = especialidad.Nombre_Especialidad;
                    txtDescripcionEspecialidad.Text = especialidad.Descripcion_Especialidad;
                    especialidadRegistrada = especialidad;
                }
                else
                {
                    MessageBox.Show("La Especialidad no esta en la base de datos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CargarListaDataSet();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            formularioBuscar = new frmBuscarEspecialidad();
            //Especificar que se va a usar el evento aceptar
            formularioBuscar.Aceptar += new EventHandler(Aceptar);
            formularioBuscar.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void grdListaEspecialista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = 0;
            try
            {
                //Recuperar el id de DGV
                id = (int)grdListaEspecialista.SelectedRows[0].Cells[0].Value;
                CargarEspecialidad(id);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmAdministrarEspecialidad_Load(object sender, EventArgs e)
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





        private void Aceptar(object id, EventArgs e)
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


    }
}// namespace
