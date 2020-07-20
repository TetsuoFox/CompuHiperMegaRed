using SuperMundoHiperMegaRed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using YoApruebo.SC;

namespace YoApruebo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        BLL.Login login = new BLL.Login();

        protected void btnentrar_Click1(object sender, EventArgs e)
        {
            if (login.authenticaticateUser(textUser.Text, textPassword.Text))
            {
                Persona persona = new Persona(textUser.Text);

                Session["name"] = persona.getName();
                Session["lastname"] = persona.getLastname();
                Session["cargo"] = persona.getCargo();
                Session["direccion"] = persona.getDireccion();
                Session["telefono"] = persona.getTelefono();

                Response.Redirect("home");
            }
            else
            {
                Label1.Text = "La contraseña o la clave no son correctas";
            }
        }
    }
}