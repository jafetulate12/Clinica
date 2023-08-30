using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaLogica;
using System.Data;
using CapaEntidades;
using System.ComponentModel;


namespace SitioWeb
{
    public partial class WebForm2 : System.Web.UI.Page
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
                       
                            txtId.Visible = true;

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
                        Limpiar();
                        txtId.Text = "-1";
                        
                        txtId.Visible = false;
                        btnCrearEspacio.Visible = false;
                    }
                }

            }
            catch (Exception ex)
            {

                mensajeScript = string.Format("javascript:mostrarMensaje('{0}')", ex.Message);
                ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
                Response.Redirect("frmClientes.aspx");
            }
            if (Session["id_del_paciente"] != null)
            {
                pnlPacientes.Visible = true;
            }
            else
            {
                pnlPacientes.Visible = false;
            }

            btnCerrarPanel0.Visible = false;
            plnEspec.Visible = false;




        }

        public void Limpiar()
        {
            txtId.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtCedula.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            Session.Remove("id_del_paciente");
        }
        public void Limpiar1()
        {
            txtId.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtCedula.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            Session.Remove("id_del_paciente");

            btnCerrarPanel0.Visible = true;
        }


        private void CargarListaDataSet(string condicion = "", string orden = "")
        {
            //carga el datagridview con el dataset
            BLEspecialWEB logica = new BLEspecialWEB(clsConfiguracion.getConnectionString);
            DataSet DSPaciente;

            try
            {
                DSPaciente = logica.ListarAgenda(condicion, orden);
                grdHorariosWeb.DataSource = DSPaciente;
                grdHorariosWeb.DataMember = DSPaciente.Tables[0].TableName;

                //Para que se visualicen los datos en web 
                grdHorariosWeb.DataBind();

            }
            catch (Exception)
            {
                throw;
            }
        }// fin CargarListaDataSet


        // variable global
        string mensajeScript = string.Empty;

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string condicion = string.Format("ESPECIALIDAD LIKE '%{0}%' ", ddlEspecialidades.Text);
                CargarListaDataSet(condicion);
            }
            catch (Exception ex)
            {


                mensajeScript = string.Format("javascript:mostrarMensaje('{0}')", ex.Message);
                ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
            }
        }




        protected void grdHorariosWeb_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdHorariosWeb.PageIndex = e.NewPageIndex;
            CargarListaDataSet();
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar1();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        protected void btnBuscarPa_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmClientes.aspx");
        }

        protected void btnGuardar_Click1(object sender, EventArgs e)
        {

        }



        protected void btnBuscarPa_Click1(object sender, EventArgs e)
        {
         
            Response.Redirect("frmClientes.aspx");
            pnlPacientes.Visible = true;
            
            btnCerrarPanel0.Visible = true;
            btnCerrar.BackColor = System.Drawing.Color.Red;
        }

        protected void btnDesplegar_Click(object sender, EventArgs e)
        {
            pnlPacientes.Visible = true;

            btnCerrarPanel0.Visible = true;
            btnCerrar.BackColor = System.Drawing.Color.Red;
        }

        protected void btnCerrarPanel_Click(object sender, EventArgs e)
        {
            pnlPacientes.Visible = false;
    
            btnCerrarPanel0.Visible = false;
        }



        protected void grdHorariosWeb_SelectedIndexChanged(object sender, EventArgs e)
        {// txt id especialidad es del especialista el id
            GridViewRow selectedRow = grdHorariosWeb.SelectedRow;
            txtId_Especialidad.Text = selectedRow.Cells[1].Text;
            txtNombreEspe.Text = selectedRow.Cells[2].Text;
            txtEspecialidad.Text = selectedRow.Cells[3].Text;
            txtHorarioInicio.Text = selectedRow.Cells[4].Text;
            txtHoraFinal.Text = selectedRow.Cells[5].Text;
            // Recuperar la fecha en formato de fecha sin la hora
            string fechaTexto = selectedRow.Cells[6].Text;
            DateTime fecha = DateTime.Parse(fechaTexto);
            string fechaFormateada = fecha.ToShortDateString(); // Formato de fecha sin la hora

            txtFecha.Text = fechaFormateada;
            plnEspec.Visible = true;
            btnCrearEspacio.Visible = true;
        }

        protected void btnCerrar_Click(object sender, EventArgs e)
        {
            plnEspec.Visible = false;

        }

        protected void BtnValidar_Click(object sender, EventArgs e)
        {
         
            
        
            

        }

        //----------------------------------------------------------------
        private EntidaCitaWeb GenerarEntidad()
        {
          
            
                EntidaCitaWeb cita = new EntidaCitaWeb();


                cita.setId_Especialista(Convert.ToInt32(txtId_Especialidad.Text));
                cita.setId_Paciente(Convert.ToInt32(txtId.Text));
                cita.setHora_Inicio(TimeSpan.Parse(txtHoraCita.Text));
                cita.setFecha(Convert.ToDateTime((txtFecha.Text)));
                return cita;
            
 
        }//fin GenerarEntidad

        protected void btnCrearEspacio_Click(object sender, EventArgs e)
        {
            EntidaCitaWeb cita;
            BLCitaWeb logica = new BLCitaWeb(clsConfiguracion.getConnectionString);
            int resultado=-1;

            try
            {
            
                if (!string.IsNullOrEmpty(txtId.Text) &&
                    (!string.IsNullOrEmpty(txtHoraCita.Text) &&
                   (!string.IsNullOrEmpty(txtId_Especialidad.Text))))
                {
                    cita = GenerarEntidad();
                    resultado = logica.Insertar(cita);
                    if (resultado > 0)
                    {
                        mensajeScript = string.Format("javascript:mostrarMensaje(' {0}')", logica.Mensaje);
                        ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
                    }
                    else
                    {
                        mensajeScript = string.Format("javascript:mostrarMensaje(' {0}')", logica.Mensaje);
                        ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
                    }
                }
                else
                {
                    mensajeScript = string.Format("javascript:mostrarMensaje(' Los datos son obligatorios')");
                    ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
                }
            }
            catch (Exception)
            {
                mensajeScript = string.Format("javascript:mostrarMensaje('Faltan datos para poder crear la Cita')");
                ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
            }
            
        }

    }
}

