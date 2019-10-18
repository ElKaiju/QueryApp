using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QueryWebApp
{
    public partial class agregarUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Click(object sendar, EventArgs e)
        {
            lbMensaje.Text = UsuarioController.CrearUsuario2(txtId.Text, txtRut.Text, txtPassword.Text, txtNombre.Text, txtApellido.Text, txtEdad.Text, ddlSexo.SelectedValue, txtTelefono.Text, txtEmail.Text, txtTipoUsuario.Text);
        }
    }
}