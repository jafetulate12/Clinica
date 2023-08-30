using System;
using System.Windows.Forms;
using CapaLogica;
using CapaEntidades;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CapaInterfaz
{
    public partial class frmAdmistrarMedicamentos : Form
    {
        public frmAdmistrarMedicamentos()
        {
            InitializeComponent();
        }

        //Variable Global
        frmBuscarMedicamento formularioBuscar;

        //variable global para un cliente
        EntidadMedicamentos MedicamentoRegistrado;

        private EntidadMedicamentos GenerarEntidadMedi()
        {
            EntidadMedicamentos Medicamento = new EntidadMedicamentos();
            if (!string.IsNullOrEmpty(txtIdMedicamento.Text))
            {
                Medicamento = MedicamentoRegistrado;
            }
            else
            {
                Medicamento = new EntidadMedicamentos();
            }
            Medicamento.setNombreMedicamento(txtNombreMedicamento.Text);
            Medicamento.setDescripcion(txtDescripcionMedicamento.Text);
            Medicamento.setIndicacionesUso(txtIndicacionesUso.Text);
            return Medicamento;
        }

        private void Limpiar()
        {
            txtIdMedicamento.Text = string.Empty;
            txtNombreMedicamento.Text = string.Empty;
            txtDescripcionMedicamento.Text = string.Empty;
            txtIndicacionesUso.Text = string.Empty;
            txtNombreMedicamento.Focus();
        }






        private void btnGuardar_Click(object sender, EventArgs e)
        {
            BLMedicamentos logica = new BLMedicamentos(Configuracion.getConnectionString);
            EntidadMedicamentos Medicamento;
            int resultado;
            string Mensaje = string.Empty;

            try
            {
                if (!string.IsNullOrEmpty(txtNombreMedicamento.Text) && !string.IsNullOrEmpty(txtDescripcionMedicamento.Text) && !string.IsNullOrEmpty(txtIndicacionesUso.Text))
                {
                    Medicamento = GenerarEntidadMedi();
                    if (!Medicamento.Existe)
                    {
                        resultado = logica.Insertar(Medicamento);
                        Mensaje = "Medicamento Insertado correctamente";
                    }
                    else
                    {
                        resultado = logica.ModificarMedicamento(Medicamento);
                        Mensaje = "Medicamento modificado correctamente";

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


        private void CargarListaDataSet(string condicion = "", string orden = "")
        {
            BLMedicamentos logica = new BLMedicamentos(Configuracion.getConnectionString);
            DataSet DSMedicamento;
            try
            {
                DSMedicamento = logica.ListarMedicamentos(condicion, orden);
                grdListaEspecialista.DataSource = DSMedicamento;
                grdListaEspecialista.DataMember = DSMedicamento.Tables["Medicamentos"].TableName;

            }
            catch (Exception)
            {
                MessageBox.Show("Ocurio un error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void CargarMedicamento(int id)
        {
            EntidadMedicamentos Medicamento = new EntidadMedicamentos();
            BLMedicamentos traerCliente = new BLMedicamentos(Configuracion.getConnectionString);

            try
            {
                Medicamento = traerCliente.ObtenerMedicamento(id);
                if (Medicamento != null)
                {
                    txtIdMedicamento.Text = Medicamento.IdMedicamento.ToString();
                    txtNombreMedicamento.Text = Medicamento.NombreMedicamento;
                    txtDescripcionMedicamento.Text = Medicamento.Descripcion;
                    txtIndicacionesUso.Text = Medicamento.IndicacionesUso;
                    MedicamentoRegistrado = Medicamento;
                }
                else
                {
                    MessageBox.Show("El Medicamento no esta en la base de datos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CargarListaDataSet();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EntidadMedicamentos medicamento;
            int resultado;
            BLMedicamentos logica = new BLMedicamentos(Configuracion.getConnectionString);
            try
            {
                if (!string.IsNullOrEmpty(txtIdMedicamento.Text))
                {
                    medicamento = logica.ObtenerMedicamento(int.Parse(txtIdMedicamento.Text));
                    if (medicamento != null)
                    {
                        //resultado = logica.EliminarConSP(cliente);
                        //MessageBox.Show(logica.Mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        resultado = logica.EliminarMedicamento(medicamento);
                        MessageBox.Show("Eliminado ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        CargarListaDataSet();
                    }
                    else
                    {
                        MessageBox.Show("Medicamento no existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        CargarListaDataSet();
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un Medicamento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            formularioBuscar = new frmBuscarMedicamento();
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



    }// frm fin 
}/// fil namespace
