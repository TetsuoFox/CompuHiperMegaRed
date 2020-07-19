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
        SC.ServerConection server_conection = new ServerConection();

        protected void Page_Load(object sender, EventArgs e)
        {
    
        }

        protected void btnentrar_Click1(object sender, EventArgs e)
        {
            if (login.authenticaticateUser(textUser.Text, textPassword.Text))
            {
                User user = new User(textUser.Text);
                Session["authorized"] = "SI";
                Session["nickname"] = textUser.Text;
                Session["name"] = user.getPersona().getName();
                Session["lastname"] = user.getPersona().getLastname();
                Session["cargo"] = user.getPersona().getCargo();
                Session["direccion"] = user.getPersona().getDireccion();
                Session["telefono"] = user.getPersona().getTelefono();
                Response.Redirect("home");
            }
            Label1.Text = "La contraseña o la clave no son correctas";
        }
    }
}