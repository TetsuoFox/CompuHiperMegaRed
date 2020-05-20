using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace YoApruebo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        BLL.Login login = new BLL.Login();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnentrar_Click1(object sender, EventArgs e)
        {
            if ( getAuthentication( textUser.Text , textPassword.Text ) == true)
            {
                Label1.Text = "si";
            }
            else
            {
                Label1.Text = "no";
            }
        }

        private bool getAuthentication(string usuario, string password)
        {
            string query = "SELECT USUARIO, PASSWORD FROM USUARIO WHERE USUARIO ='" + usuario + "'";
            bool respuesta = login.getUseryPass(query, password);
            return respuesta;
        }
    }
}