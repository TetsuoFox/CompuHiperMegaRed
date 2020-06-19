using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace YoApruebo
{
    public partial class _Usuario: Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AgregarUsuario_Click(object sender, EventArgs e)
        {
            if (textPass1.Text.Equals(textPass2.Text))
            {

            }
            else {
                lblAd.Text = "Las Contraseña no coinciden";
                textPass2.CssClass = "form-control is-invalid";
                textPass1.CssClass = "form-control is-invalid";
            }
            if (textNombre.Text.Equals(""))
            {
            textNombre.CssClass = "form-control is-invalid";
            }
            if (textApellido.Text.Equals(""))
            {
                textApellido.CssClass = "form-control is-invalid";
            }
            if (textNombre.Text.Equals(""))
            {
                textNombre.CssClass = "form-control is-invalid";
            }
            if (textNombre.Text.Equals(""))
            {
                textNombre.CssClass = "form-control is-invalid";
            }
            if (textNombre.Text.Equals(""))
            {
                textNombre.CssClass = "form-control is-invalid";
            }
            if (textNombre.Text.Equals(""))
            {
                textNombre.CssClass = "form-control is-invalid";
            }
            if (textNombre.Text.Equals(""))
            {
                textNombre.CssClass = "form-control is-invalid";
            }
            if (textNombre.Text.Equals(""))
            {
                textNombre.CssClass = "form-control is-invalid";
            }
            if (textNombre.Text.Equals(""))
            {
                textNombre.CssClass = "form-control is-invalid";
            }
            if (textNombre.Text.Equals(""))
            {
                textNombre.CssClass = "form-control is-invalid";
            }
            if (textNombre.Text.Equals(""))
            {
                textNombre.CssClass = "form-control is-invalid";
            }
            if (textNombre.Text.Equals(""))
            {
                textNombre.CssClass = "form-control is-invalid";
            }
        }
    }
}