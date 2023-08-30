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
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Se ejecuta cuando se refresca la pagina
            try
            {
                if (!IsPostBack)
                {
                    CargarListaDataSet();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        // variable global
        string mensajeScript = string.Empty;

        private void CargarListaDataSet(string condicion = "", string orden = "")
        {
            //carga el datagridview con el dataset
               BLPacientes logica = new BLPacientes(clsConfiguracion.getConnectionString);
            DataSet DSPaciente;

            try
            {
                DSPaciente = logica.ListarPacientes(condicion, orden);
                grdPacientes.DataSource = DSPaciente;
                grdPacientes.DataMember = DSPaciente.Tables[0].TableName;
                //Para que se visualicen los datos en web 
                grdPacientes.DataBind();
            }
            catch (Exception)
            {
                throw;
            }
        }// fin CargarListaDataSet

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string condicion = string.Format("NOMBRE_COMPLETO_PACIENTE LIKE '%{0}%' ", txtBuscar.Text);
                CargarListaDataSet(condicion);
            }
            catch (Exception ex)
            {


                mensajeScript = string.Format("javascript:mostrarMensaje('{0}')", ex.Message);
                ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            //  eliminamos la variable de session 
            Session.Remove("id_del_paciente");

            // redireccionamos 
            Response.Redirect("frmBuscarPaciente.aspx");
        }


        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("PaginaPrincipal.aspx");
        }

        protected void grdPacientes_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdPacientes.PageIndex = e.NewPageIndex;
            CargarListaDataSet();
        }

       // protected void LnkEliminar_Click(object sender, EventArgs e)
       // {

   //     }////

        protected void LnkEliminar_Command(object sender, CommandEventArgs e)
        {
            // leeer el idque es enviado por el commandaevet
            int id = int.Parse(e.CommandArgument.ToString());
            BLPacientes logica = new BLPacientes(clsConfiguracion.getConnectionString);
            EntidadPacientes paciente;
            try
            {
                paciente = logica.obtenerPaciente(id);
                if (paciente.Existe)
                {
                    if (logica.EliminarConSP(paciente) > 0)
                    {
                        // mensaje
                        mensajeScript = string.Format("javascript:mostrarMensaje('{0}')", logica.Mensaje);
                        ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
                        CargarListaDataSet();
                    }
                    else
                    {
                        mensajeScript = string.Format("javascript:mostrarMensaje('El paciente tiene citas agendadas')");
                        ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
                        CargarListaDataSet();
                    }
                }
            }
            catch (Exception )
            {
                mensajeScript = string.Format("javascript:mostrarMensaje(''El paciente tiene citas agendadas')");
                ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
                CargarListaDataSet();
            }

        }

       // protected void LinkModificar_Click(object sender, EventArgs e)
        //{

        //}

        protected void LinkModificar_Command(object sender, CommandEventArgs e)
        {
            Session["id_del_paciente"] = e.CommandArgument.ToString();
            // redirecccioonamos a:
            Response.Redirect("frmBuscarPaciente.aspx");
        }

        protected void LinkSeleccionar_Command(object sender, CommandEventArgs e)
        {
            Session["id_del_paciente"] = e.CommandArgument.ToString();
            //Redireccionamos 
            Response.Redirect("AgendarCita.aspx"); //Seleccionar
         
        }
    }
}