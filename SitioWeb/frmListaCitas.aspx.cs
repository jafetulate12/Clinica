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
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            CargarListaDataSet();
 
        }
        // variable global
        string mensajeScript = string.Empty;

        private void CargarListaDataSet(string condicion = "", string orden = "")
        {
            //carga el datagridview con el dataset
            BLCitaWeb logica = new BLCitaWeb(clsConfiguracion.getConnectionString);
            DataSet DSCita;

            try
            {
                DSCita = logica.listarCita(condicion, orden);
                grdListCitas.DataSource = DSCita;
                grdListCitas.DataMember = DSCita.Tables[0].TableName;
                //Para que se visualicen los datos en web 
                grdListCitas.DataBind();
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
    }
}