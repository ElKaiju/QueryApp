using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QueryWebApp
{
    public partial class admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MensajeController.CrearMensaje();

            if (!IsPostBack)
            {
                CargarMensajes();
            }

        }

        private void CargarMensajes()
        {
            var msg = from m1 in MensajeController.GetMensajes()
                      select new
                      {
                          USUARIO = m1._tipoMensaje,
                          MENSAJE = m1._elMensaje
                      };

            grdMensaje.DataSource = msg;
            grdMensaje.DataBind();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("agregarUsuario.aspx");
        }
    }
}