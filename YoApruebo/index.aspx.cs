using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
            if ( getAuthentication( textUser.Text , textPassword.Text ) == true)
            {
                Label1.Text = "si";
            }
            else
            {
                Label1.Text = "no";
            }

            bool v = server_conection.AutenticatheUser("asdasd", "asdas");
        }

        private bool getAuthentication(string usuario, string password)
        {
            string query = "SELECT USUARIO, PASSWORD FROM USUARIO WHERE USUARIO ='" + usuario + "'";
            bool respuesta = login.getUseryPass(query, password);
            return respuesta;
        }
    }
}