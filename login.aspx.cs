using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QueryWebApp
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UsuarioController.crearUsuario();   
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Usuario u = UsuarioController.buscarUsuario(txtUser.Text);
            if (u != null)
            {
                if (u._password.Equals(txtPass.Text))
                {
                    Session["user"] = u;
                    //lbMensaje.Text = "Entraste!";

                    if (u._tipoUsuario.Equals("admin")) {
                        Response.Redirect("admin.aspx");
                    }
                    else
                    {
                        Response.Redirect("usuario.aspx");
                    }
                }
                else
                {
                    lbMensaje.Text = "No es posible encontrar este usuario o la contraseña está incorrecta.";
                    Session["user"] = null;
                }
            }

        }
    }
}