using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SuperMundoHiperMegaRed
{
    public partial class index2 : System.Web.UI.Page
    {
        YoApruebo.BLL.Login login = new YoApruebo.BLL.Login();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnentrar_Click1(object sender, EventArgs e)
        {
            lblUser.Text = "";
            lblPass.Text = "";
            lblMsg.Text = "";

            if (textUser.Text.Equals(""))
            {
                lblMsg.Text = "Los datos son obligatorios";
                lblUser.Text = "*";
            }
            if (textPassword.Text.Equals(""))
            {
                lblMsg.Text = "Los datos son obligarios";
                lblPass.Text = "*";
            }
            else
            {
                bool r = getAuthentication(textUser.Text, textPassword.Text);
                if (r == true)
                    //lblMsg.Text = "OK";
                    Response.Redirect("index");
                else
                    lblMsg.Text = "Usuario o password invalida";
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