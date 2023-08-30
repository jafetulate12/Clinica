using System.Windows.Forms;
using System;
using CapaLogica;
using CapaEntidades;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CapaInterfaz
{
    public partial class frmAdministrarEspecialistas : Form
    {
        public frmAdministrarEspecialistas()
        {
            InitializeComponent();
        }
        //Variable Global
        frmBuscarEspecialistas formularioBuscar;

        //variable global para un cliente
        EntidadEspecialistas EspecialistaRegistrado;

        //Generar la entidad Cliente
        private EntidadEspecialistas GenerarEntidadESP()
        {
            EntidadEspecialistas Especialista = new EntidadEspecialistas();
            if (!string.IsNullOrEmpty(txtIdEspecialista.Text))
            {
                Especialista = EspecialistaRegistrado;
            }
            else
            {
                Especialista = new EntidadEspecialistas();
            }
            Especialista.setNombre_Especialista(txtNombreEspecialista.Text);
            Especialista.setTelefono_Especialista(Convert.ToInt32(txtTelefonoEspecialista.Text));
            Especialista.setCorreo_Especialista(txtCorreoEspecialista.Text);
            Especialista.setDireccion_Especialista(txtDireccionEspecialista.Text);
            return Especialista;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            formularioBuscar = new frmBuscarEspecialistas();
            //Especificar que se va a usar el evento aceptar
            formularioBuscar.Aceptar += new EventHandler(Aceptar);
            formularioBuscar.ShowDialog();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            BLEspecialistas logica = new BLEspecialistas(Configuracion.getConnectionString);
            EntidadEspecialistas Especialista;
            int resultado;
            string Mensaje = string.Empty;

            try
            {
                if (!string.IsNullOrEmpty(txtNombreEspecialista.Text) && !string.IsNullOrEmpty(txtTelefonoEspecialista.Text) && !string.IsNullOrEmpty(txtCorreoEspecialista.Text)  && !string.IsNullOrEmpty(txtDireccionEspecialista.Text))
                {
                    Especialista = GenerarEntidadESP();
                    if (!Especialista.Existe)
                    {
                        resultado = logica.Insertar(Especialista);
                        Mensaje = "Cliente Insertado correctamente";
                    }
                    else
                    {
                        resultado = logica.ModificarClientes(Especialista);
                        Mensaje = "Cliente modificado correctamente";

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
        }// fin btn guardar

        private void Limpiar()
        {
            txtIdEspecialista.Text = string.Empty;
            txtNombreEspecialista.Text = string.Empty;
            txtTelefonoEspecialista.Text = string.Empty;
            txtCorreoEspecialista.Text = string.Empty;
            txtDireccionEspecialista.Text = string.Empty;
            txtNombreEspecialista.Focus();
        }

        private void CargarListaDataSet(string condicion = "", string orden = "")
        {
            BLEspecialistas logica = new BLEspecialistas(Configuracion.getConnectionString);
            DataSet DSEspecialista;
            try
            {
                DSEspecialista = logica.ListarEspecialista(condicion, orden);
                grdListaEspecialista.DataSource = DSEspecialista;
                grdListaEspecialista.DataMember = DSEspecialista.Tables["Especialistas"].TableName;

            }
            catch (Exception)
            {
                MessageBox.Show("Ocurio un error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }// fin dataset

        private void CargarEspecialista(int id)
        {
            EntidadEspecialistas Especialista = new EntidadEspecialistas();
            BLEspecialistas traerEspecialista= new BLEspecialistas(Configuracion.getConnectionString);

            try
            {
                Especialista = traerEspecialista.ObtenerEspecialista(id);
                if (Especialista != null)
                {
                    txtIdEspecialista.Text = Especialista.Id_Especialista.ToString();
                    txtNombreEspecialista.Text = Especialista.Nombre_Especialista;
                    txtTelefonoEspecialista.Text = Especialista.Telefono_Especialista.ToString();
                    txtCorreoEspecialista.Text = Especialista.Corro_Especialista;
                    txtDireccionEspecialista.Text = Especialista.Direccion_Especialista;

                    EspecialistaRegistrado = Especialista;
                }
                else
                {
                    MessageBox.Show("El cliente no esta en la base de datos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CargarListaDataSet();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmAdministrarEspecialistas_Load(object sender, EventArgs e)
        {
            try
            {
                CargarListaDataSet();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }// fin load

        private void Aceptar(object id, EventArgs e)
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

        private void grdListaEspecialista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = 0;
            try
            {
                //Recuperar el id de DGV
                id = (int)grdListaEspecialista.SelectedRows[0].Cells[0].Value;
                CargarEspecialista(id);

            }
            catch (Exception )
            {
                MessageBox.Show("en grrd", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EntidadEspecialistas Especialista;
            int resultado;
            BLEspecialistas logica = new BLEspecialistas(Configuracion.getConnectionString);
            try
            {
                if (!string.IsNullOrEmpty(txtIdEspecialista.Text))
                {
                    Especialista = logica.ObtenerEspecialista(int.Parse(txtIdEspecialista.Text));
                    if (Especialista != null)
                    {
                        //resultado = logica.EliminarConSP(cliente);
                        //MessageBox.Show(logica.Mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        resultado = logica.EliminarEspecialista(Especialista);
                        MessageBox.Show("Eliminado sin SP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        CargarListaDataSet();
                    }
                    else
                    {
                        MessageBox.Show("Cliente no existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        CargarListaDataSet();
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    } //fin frm adminstar especialistas
   
}// fin  namespace
