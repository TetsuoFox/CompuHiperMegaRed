using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using YoApruebo.BLL;

using System.Drawing;

namespace SuperMundoHiperMegaRed.Almacenes
{
    public partial class editarAlmacenPage : System.Web.UI.Page
    {
       List<almacen> almacenes = new List<almacen>();
        Ingreso insertarBD = new Ingreso();
   public string idAlmacenActualizar;


        protected void Page_Load(object sender, EventArgs e)
        { //---
        
            //-----
            List<almacen> lista = traeAlmacenes();
            if (!this.IsPostBack)
            {
                DataTable dt = new DataTable();
                dt.Columns.AddRange(new DataColumn[3] { new DataColumn("Id"), new DataColumn("Almacen"), new DataColumn("Estado") });

                foreach (almacen al in lista)
                {
                    ListItem li = new ListItem(al.nombreAlmacen, al.id.ToString());
                    String esActivo = al.esActivo ? "Si" : "No";
                    dt.Rows.Add(al.id, al.nombreAlmacen, esActivo);
                }
                GridView1.DataSource = dt;
                GridView1.DataBind();

                GridView1.HeaderRow.CssClass = "thead-dark";
         

      

            }
        }


        private void mostrarModal(almacen al)
        {
            lblId.Text = al.id;
            lblModalTitle.Text = "Editando " + al.nombreAlmacen;
            idAlmacenActualizar = al.id;
            // lblModalBody.Text = "This is modal body";
            txtNombreAlmacen.Text = al.nombreAlmacen;
            chkActivo.Checked = al.esActivo;
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#myModal').modal();", true);
            upModal.Update();
        }


        protected void OnRowDataBound(object sender, System.Web.UI.WebControls.GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(GridView1, "Select$" + e.Row.RowIndex);
                e.Row.ToolTip = "Haga Click para editar";
            }
        }
        protected void OnSelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (GridViewRow row in GridView1.Rows)
            {
                if (row.RowIndex == GridView1.SelectedIndex)
                {
                    string nombreActual = row.Cells[0].Text;
                    foreach(almacen al in almacenes)
                    {
                        if(al.nombreAlmacen.Equals(row.Cells[0].Text))
                        {

                            mostrarModal(al);
                            idAlmacenActualizar = al.id;
                        }
                    }

                    row.CssClass = "table-dark table-borderless";
                    row.ToolTip = string.Empty;
                }
                else
                {
                    row.CssClass = "thead-light";
                    //row.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                    row.ToolTip = "Click to select this row.";
                }
            }
        }
        List<almacen> traeAlmacenes()
        {
            almacenes = new List<almacen>();
            String query = "Select * from almacen";
            DataTable tabla = insertarBD.getPerfil(query);
            almacen almacenObj;
           for(int i = 0;i<=tabla.Rows.Count-1;i++)
            {
                string id = tabla.Rows[i]["id_almacen"].ToString();
                bool estado = tabla.Rows[i]["estado"].ToString().Equals("1") ? true : false;
                almacenObj = new almacen(tabla.Rows[i]["almacen"].ToString(), estado,id);
                almacenes.Add(almacenObj);
            }
            return almacenes;
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {

        }

        protected void drop1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
             
        }

        almacen traeAlmacen(string idM )
        {
            foreach (almacen al in almacenes)
            {
                if (al.id.Equals(idM))
                {
                    return al;
                }

            }
            return null;
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            string activo = chkActivo.Checked?"1":"0";
            String query = "update almacen set almacen = '" + txtNombreAlmacen.Text + "', estado = '" + activo + "' where id_almacen = " + lblId.Text;
            insertarBD.ingresar(query);
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "#myModal", "$('body').removeClass('modal-open');$('.modal-backdrop').remove();", true);
            Response.Redirect(Request.RawUrl);

        }
    }
}