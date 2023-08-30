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
    public partial class frmAdministrarDiagnostico : Form
    {
        public frmAdministrarDiagnostico()
        {
            InitializeComponent();
        }

        frmBuscarEspecialistas formularioBuscar;

        frmBuscarDiagnostico formularioBuscarDIAG;

        EntidadDiagnostico DiagnosticoRegistrado;

        private EntidadDiagnostico GenerarEntidadDiag()
        {
            EntidadDiagnostico diagnostico = new EntidadDiagnostico();
            if (!string.IsNullOrEmpty(txtIdDisgnostico.Text))
            {
                diagnostico = DiagnosticoRegistrado;
                
            }
            else
            {
                diagnostico = new EntidadDiagnostico();
            }
            diagnostico.setId_Especialista(Convert.ToInt32(txtIdEspecialista.Text));
            diagnostico.setFecha_Diagnostico(Convert.ToDateTime(dtpFechaDiagnostico.Text));
            diagnostico.setResultados_Diagnostico(txtResultadoDisgnostico.Text);
            return diagnostico;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            BLDiagnostico logica = new BLDiagnostico(Configuracion.getConnectionString);
            EntidadDiagnostico diagnostico;
            int resultado;
            string Mensaje = string.Empty;

            try
            {
                if (!string.IsNullOrEmpty(txtIdEspecialista.Text) && !string.IsNullOrEmpty(dtpFechaDiagnostico.Text) && !string.IsNullOrEmpty(txtResultadoDisgnostico.Text))
                {
                    diagnostico = GenerarEntidadDiag();
                    if (!diagnostico.Existe)
                    {
                        resultado = logica.Insertar(diagnostico);
                        Mensaje = "Diagnostico Insertado correctamente";
                    }
                    else
                    {
                        resultado = logica.ModificarClientes(diagnostico);
                        Mensaje = "Diagnostico modificado correctamente";

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
            txtIdEspecialista.Text = string.Empty;
            txtIdEspecialista.Text = string.Empty;
            dtpFechaDiagnostico.Text = string.Empty;
            txtResultadoDisgnostico.Text = string.Empty;
            dtpFechaDiagnostico.Focus();
        }


        private void CargarListaDataSet(string condicion = "", string orden = "")
        {
            BLDiagnostico logica = new BLDiagnostico(Configuracion.getConnectionString);
            DataSet DSDiagnostico;
            try
            {
                DSDiagnostico = logica.ListarDiagnosticos(condicion, orden);
                grdListaDiagnostico.DataSource = DSDiagnostico;
                grdListaDiagnostico.DataMember = DSDiagnostico.Tables["Diagnosticos"].TableName;

            }
            catch (Exception)
            {
                MessageBox.Show("Ocurio un error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmAdministrarDiagnostico_Load(object sender, EventArgs e)
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

        private void AceptarEsp(object id, EventArgs e)
        {
            try
            {
                int idEspecialista = (int)id;

                if (idEspecialista != -1)
                {
                    CargarEsp(idEspecialista);
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


        private void CargarEsp(int id)
        {
            EntidadEspecialistas Especialista = new EntidadEspecialistas();
            BLEspecialistas traerEspecialista = new BLEspecialistas(Configuracion.getConnectionString);

            try
            {
                Especialista = traerEspecialista.ObtenerEspecialista(id);
                if (Especialista != null)
                {
                    txtIdEspecialista.Text = Especialista.Id_Especialista.ToString();

                }
                else
                {
                    MessageBox.Show("El Diagnostico no esta en la base de datos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CargarListaDataSet();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            formularioBuscar = new frmBuscarEspecialistas();
            //Especificar que se va a usar el evento aceptar
            formularioBuscar.Aceptar += new EventHandler(AceptarEsp);
            formularioBuscar.ShowDialog();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EntidadDiagnostico diagnostico;
            int resultado;
            BLDiagnostico logica = new BLDiagnostico(Configuracion.getConnectionString);
            try
            {
                if (!string.IsNullOrEmpty(txtIdDisgnostico.Text))
                {
                    diagnostico = logica.ObtenerDiagnostico(int.Parse(txtIdDisgnostico.Text));
                    if (diagnostico != null)
                    {
                        //resultado = logica.EliminarConSP(cliente);
                        //MessageBox.Show(logica.Mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        resultado = logica.EliminaDiagnosticos(diagnostico);
                        MessageBox.Show("Eliminado  ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        CargarListaDataSet();
                    }
                    else
                    {
                        MessageBox.Show("Diagnostico no existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        CargarListaDataSet();
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un Diagnostico", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDiagnostico(int id)
        {
            EntidadDiagnostico diagnostico= new EntidadDiagnostico();
            BLDiagnostico traerDiagnostico = new BLDiagnostico(Configuracion.getConnectionString);

            try
            {
                diagnostico = traerDiagnostico.ObtenerDiagnostico(id);
                if (diagnostico != null)
                {
                    txtIdDisgnostico.Text = diagnostico.Id_Diagnostico.ToString();
                    txtIdEspecialista.Text = diagnostico.Id_Diagnostico.ToString();
                    txtResultadoDisgnostico.Text = diagnostico.Resultados_Diagnostico;
                    dtpFechaDiagnostico.Value = (DateTime)diagnostico.Fecha_Diagnostico;
                    DiagnosticoRegistrado = diagnostico;
                }
                else
                {
                    MessageBox.Show("El Diagnostico no esta en la base de datos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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



        private void btnBuscarDIAG_Click(object sender, EventArgs e)
        {
            formularioBuscarDIAG = new frmBuscarDiagnostico();
            //Especificar que se va a usar el evento aceptar
            formularioBuscarDIAG.Aceptar += new EventHandler(Aceptar);
            formularioBuscarDIAG.ShowDialog();
        }
    }// fin frmadministrar
}// frm namespace
