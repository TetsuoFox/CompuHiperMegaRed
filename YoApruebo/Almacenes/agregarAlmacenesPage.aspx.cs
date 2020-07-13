using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using YoApruebo.BLL;
namespace SuperMundoHiperMegaRed.Almacenes.Agregar_Almacenes
{
    public partial class agregarAlmacenesPage : System.Web.UI.Page
    {
        Ingreso insertarBD = new Ingreso();
        protected void Page_Load(object sender, EventArgs e)
        {
            llenaTablaAlmacenes();
        }

        protected void agregarAlmacen_Click(object sender, EventArgs e)
        {

            agregarAlmacenes(txtNombreAlmacen.Text, chkActivo.Checked);

        }


        public void agregarAlmacenes(String nombre, bool estado)
        {
            int intEstado = estado ? 1 : 0;
            String query = "Insert into ALMACEN (almacen, estado) values ('" + nombre + "'," + intEstado + ")";
            insertarBD.ingresar(query);
            llenaTablaAlmacenes();
        }

        public void llenaTablaAlmacenes(String query)
        {
           
            DataTable tabla = insertarBD.getPerfil(query);
            tblAlmacenes.DataSource = tabla;
            tblAlmacenes.DataBind();
        }
            public void llenaTablaAlmacenes()
            {
               String query = "Select * from almacen";
                DataTable tabla = insertarBD.getPerfil(query);
                tblAlmacenes.DataSource = tabla;
                tblAlmacenes.DataBind();
            tblAlmacenes.HeaderRow.CssClass = "thead-dark"; 


        }

        

        protected void btnActualizaTbl_Click(object sender, EventArgs e)
        {if(chkTraeActivos.Checked)
            {
                llenaTablaAlmacenes();
            }
            else
            {
                llenaTablaAlmacenes("Select * from almacen where ESTADO = '1'");
            }
           
        }
    }
}