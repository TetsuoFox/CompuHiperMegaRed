using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SuperMundoHiperMegaRed
{
    public partial class pageJC : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void btn1_Click(object sender, EventArgs e)
        {

            lbl1.Text = "Hola jeje";

        }

    

        protected void btn2_Click(object sender, EventArgs e)
        {
            lbl1.Text = "Hola jeje2";
        }

        protected void btn3_Click(object sender, EventArgs e)
        {
            lbl2.Text = "Actualizacion pagina completa";
        }
    }
}