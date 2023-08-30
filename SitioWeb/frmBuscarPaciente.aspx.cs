using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaEntidades;
using CapaLogica;

namespace SitioWeb
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            EntidadPacientes paciente;
            BLPacientes logica = new BLPacientes(clsConfiguracion.getConnectionString);
            int identificacion;
            try
            {
                if (!Page.IsPostBack)
                {
                    // si el id se obtiene en el otro formulario
                    if (Session["id_del_paciente"] != null)
                    {
                        identificacion = int.Parse(Session["id_del_paciente"].ToString());
                        paciente = logica.obtenerPaciente(identificacion);
                        if (paciente.Existe)
                        {
                            txtId.Text = paciente.IdPaciente.ToString();
                            txtCedula.Text = paciente.CedulaPaciente.ToString();
                            txtNombre.Text = paciente.NombrePaciente;
                            txtTelefono.Text = paciente.TelefonoPaciente.ToString();
                            txtCorreo.Text = paciente.CorrreoPaciente;
                            txtDireccion.Text = paciente.DireccionPacientes;
                            lblId.Visible = true;
                            txtId.Visible = true;
                            txtCedula.Visible = true;
                            lblCedula.Visible = true;

                            

                        }
                        else
                        {// cliete encontrado
                            mensajeScript = string.Format("javascript:mostrarMensaje('Paciente no encontrado')");
                            ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
                        }
                    }
                    else
                    {
                        // si la sesion no tiene nada es que agregamaos un nuevo cliente
                        limpiar();
                        txtId.Text = "-1";
                        lblId.Visible = false;
                        txtId.Visible = false;
                    }
                }

            }
            catch (Exception ex)
            {

                mensajeScript = string.Format("javascript:mostrarMensaje('{0}')", ex.Message);
                ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
                Response.Redirect("frmClientes.aspx");
            }
        }

        // variable global
        string mensajeScript = string.Empty;

        public void limpiar()
        {
            txtId.Text = string.Empty;
            txtCedula.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtDireccion.Text = string.Empty;

        }

        private EntidadPacientes  GenerarEntidad ()
        {
            EntidadPacientes paciente = new EntidadPacientes();
            if (Session["id_del_paciente"] != null)
            {
                // modificar
                paciente.IdPaciente = int.Parse(Session["id_del_paciente"].ToString());
                paciente.Existe = true;
            }
            else
            {
                paciente.IdPaciente = -1;
                paciente.Existe = false;
            }
            paciente.setCedulaPaciente(txtCedula.Text);
            paciente.setNombrePaciente(txtNombre.Text);
            paciente.setTelefonoPaciente(Convert.ToInt32(txtTelefono.Text));
            paciente.setCorreoPaciente(txtCorreo.Text);
            paciente.setDireccionPacientes(txtDireccion.Text);
            return paciente;
        }//fin GenerarEntidad

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            EntidadPacientes paciente;
            BLPacientes logica = new BLPacientes(clsConfiguracion.getConnectionString);
            int resultado;
            try
            {
                paciente = GenerarEntidad();
                if (!string.IsNullOrEmpty(txtNombre.Text))
                {

                    if (paciente.Existe)
                    {
                        //modifficar
                        resultado = logica.ModificarPacientes(paciente);

                    }
                    else
                    {

                        resultado = logica.insertar(paciente);

                    }
                    if (resultado > 0)
                    {

                        mensajeScript = string.Format("javascript:mostrarMensaje('Operacion exitosa')");
                        ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
                       
                    }
                    else
                    {
                        mensajeScript = string.Format("javascript:mostrarMensaje('No se puede ejecutar la operacion')");
                        ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
                    }
                }
                else
                {

                    mensajeScript = string.Format("javascript:mostrarMensaje('Debe completar los datos dfel cliente')");
                    ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
                }

            }
            catch (Exception ex)
            {

                mensajeScript = string.Format("javascript:mostrarMensaje('{0}')", ex.Message);
                ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmClientes.aspx");
        }
    }
}