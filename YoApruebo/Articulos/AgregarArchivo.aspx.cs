using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SuperMundoHiperMegaRed.Articulos
{
    public partial class AgregarArchivo : System.Web.UI.Page
    {
        YoApruebo.BLL.Ingreso ingreso = new YoApruebo.BLL.Ingreso();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AgregarArticuloClick(object sender, EventArgs e)
        {
            string query = "Insert into Persona (Insert into ARTICULO(articulo, tipo_articulo, cod_qr, cod_sku, FECHA_HORA_CREACION) values('" + text_id_articulo.Text + "' , '" + asdasd  +")";
            //Insert into ARTICULO(articulo, tipo_articulo, cod_qr, cod_sku, FECHA_HORA_CREACION) values('regla', 1, 'aweras', 'waersad', CONVERT(DATETIME, '2016-10-23 20:44:11', 120));
            ingreso.ingresar(query);
            {


            }
        }
    }
}