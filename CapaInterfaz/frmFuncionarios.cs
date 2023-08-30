using System;
using System.Windows.Forms;
using CapaLogica;
using CapaEntidades;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CapaInterfaz
{
    public partial class frmFuncionarios : Form
    {
        public frmFuncionarios()
        {
            InitializeComponent();
        }

        //Variable Global
        frmBuscarFuncionario formularioBuscar;

        //variable global para un cliente
        EntidadFuncionarios FuncionarioRegistrado;

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private EntidadFuncionarios GenerarEntidadFunc()
        {
            EntidadFuncionarios funcionario = new EntidadFuncionarios();
            if (!string.IsNullOrEmpty(txtIDFuncionario.Text))
            {
                funcionario = FuncionarioRegistrado;
            }
            else
            {
                funcionario = new EntidadFuncionarios();
            }
            funcionario.SetPuesto_Funcionario(txtPuestoFuncionario.Text);
            funcionario.SetNombre_Completo_Funcionario(txtNombreFuncionario.Text);
            funcionario.SetTelefono_Funcionario(Convert.ToInt32(txtTelefonoFuncionario.Text));
            funcionario.SetCorreo_Funcionario(txtCorreoFuncionario.Text);
            return funcionario;
        }

        private void Limpiar()
        {
            txtIDFuncionario.Text = string.Empty;
            txtPuestoFuncionario.Text = string.Empty;
            txtNombreFuncionario.Text = string.Empty;
            txtTelefonoFuncionario.Text = string.Empty;
            txtCorreoFuncionario.Text = string.Empty;
            txtIDFuncionario.Focus();
        }// fin  limpiar

        //cargar la lista de clientes con un DataSet
        public void CargarListaDataSet(string condicion = "", string orden = "")
        {
            BLFuncionarios logica = new BLFuncionarios(Configuracion.getConnectionString);
            DataSet DSFuncionarios;
            try
            {
                DSFuncionarios = logica.ListarClientes(condicion, orden);
                grdListaFuncionario.DataSource = DSFuncionarios;
                grdListaFuncionario.DataMember = DSFuncionarios.Tables["FUNCIONARIOS"].TableName;

            }
            catch (Exception)
            {
                MessageBox.Show("Ocurio un error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }// FIN CARGAR LISTA DATA SET

        private void CargarFuncionario(int id)
        {
            EntidadFuncionarios funcionario = new EntidadFuncionarios();
            BLFuncionarios traerCliente = new BLFuncionarios(Configuracion.getConnectionString);

            try
            {
                funcionario = traerCliente.ObtenerFuncionario(id);
                if (funcionario != null)
                {
                    txtIDFuncionario.Text = funcionario.Id_Funcionario.ToString();
                    txtPuestoFuncionario.Text = funcionario.Puesto_Funcionario;
                    txtNombreFuncionario.Text = funcionario.Nombre_Completo_Funcionario;
                    txtTelefonoFuncionario.Text = funcionario.Telefono_Funcionario.ToString();
                    txtCorreoFuncionario.Text = funcionario.Correo_Funcionario;
                    FuncionarioRegistrado = funcionario;
                }
                else
                {
                    MessageBox.Show("El Funcionario no esta en la base de datos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CargarListaDataSet();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmFuncionarios_Load(object sender, EventArgs e)
        {

        }// fin carga funcionarios 

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            BLFuncionarios logica = new BLFuncionarios(Configuracion.getConnectionString);
            EntidadFuncionarios funcionario;
            int resultado;
            string Mensaje = string.Empty;

            try
            {
                if (!string.IsNullOrEmpty(txtPuestoFuncionario.Text) && !string.IsNullOrEmpty(txtNombreFuncionario.Text) && !string.IsNullOrEmpty(txtTelefonoFuncionario.Text) && !string.IsNullOrEmpty(txtCorreoFuncionario.Text))
                {
                    funcionario = GenerarEntidadFunc();
                    if (!funcionario.Existe)
                    {
                        resultado = logica.Insertar(funcionario);
                        Mensaje = "Funcionario Insertado correctamente";
                    }
                    else
                    {
                       resultado= logica.ModificarClientes(funcionario);
                        Mensaje = "Funcionario modificado correctamente";

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
        }// fin ghuardar

        private void grdListaFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = 0;
            try
            {
                //Recuperar el id de DGV
                id = (int)grdListaFuncionario.SelectedRows[0].Cells[0].Value;
                CargarFuncionario(id);

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

        private void frmFuncionarios_Load_1(object sender, EventArgs e)
        {
            CargarListaDataSet();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EntidadFuncionarios funcionario;
            int resultado;
            BLFuncionarios logica = new BLFuncionarios(Configuracion.getConnectionString);
            try
            {
                if (!string.IsNullOrEmpty(txtIDFuncionario.Text))
                {
                    funcionario = logica.ObtenerFuncionario(int.Parse(txtIDFuncionario.Text));
                    if (funcionario != null)
                    {
                        //resultado = logica.EliminarConSP(cliente);
                        //MessageBox.Show(logica.Mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        resultado = logica.EliminarFuncionario(funcionario);
                        MessageBox.Show("Eliminado ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        CargarListaDataSet();
                    }
                    else
                    {
                        MessageBox.Show("Funcionario no existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        CargarListaDataSet();
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un Funcionario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }// fin btn elimanr

        private void Aceptar(object id, EventArgs e)
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //frm.Show();
            formularioBuscar = new frmBuscarFuncionario();
            //Especificar que se va a usar el evento aceptar
            formularioBuscar.Aceptar += new EventHandler(Aceptar);
            formularioBuscar.ShowDialog();
        }
    }// fin frm funcionario
}// fin namespace
