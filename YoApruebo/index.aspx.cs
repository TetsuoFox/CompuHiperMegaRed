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
                Session["authorized"] = "SI";
                Response.Redirect("home");
                //AddUserToSession("textUser.Text");
            }
            Label1.Text = "La contraseña o la clave no son correctas";
        }

        public static void AddUserToSession(string id)
        {
            bool persist = true;
            // generar cookie de autenticación
            FormsAuthentication.SetAuthCookie(id, persist);
            var cookie = FormsAuthentication.GetAuthCookie(id, persist);

            cookie.Name = FormsAuthentication.FormsCookieName;
            cookie.Expires = DateTime.Now.AddMonths(3);

            var ticket = FormsAuthentication.Decrypt(cookie.Value);
            var newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, ticket.IssueDate, ticket.Expiration, ticket.IsPersistent, id);

            cookie.Value = FormsAuthentication.Encrypt(newTicket);
            HttpContext.Current.Response.Cookies.Add(cookie);
        }
    }
}