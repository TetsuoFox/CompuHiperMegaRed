using SuperMundoHiperMegaRed;
using System;

namespace YoApruebo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "";
        }
        protected void btnentrar_Click1(object sender, EventArgs e)
        {
            BLL.Login login = new BLL.Login();

            if (login.authenticaticateUser(textUser.Text, textPassword.Text))
            {
                SessionStart();
                Response.Redirect("home");
            }
            else
            {
                Label1.Text = "El nombre de usuario o la contraseña no son correctos";
            }
        }

        private void SessionStart()
        {
            Persona persona = new Persona(textUser.Text);

            Session["nickname"] = textUser.Text;

            Session["name"] = persona.name;
            Session["lastname"] = persona.lastname;
            Session["cargo"] = persona.cargo;
            Session["direccion"] = persona.direccion;
            Session["telefono"] = persona.telefono;
        }
    }
}