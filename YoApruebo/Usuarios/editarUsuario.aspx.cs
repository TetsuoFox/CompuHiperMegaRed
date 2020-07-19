using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using YoApruebo.BLL;
using System.Drawing;


namespace SuperMundoHiperMegaRed.Usuarios
{
    public partial class editarUsuario : System.Web.UI.Page
    {
        List<usuario> usuarios = new List<usuario>();
        Ingreso insertarBD = new Ingreso();
        string idpersona;
        string idperfil;
        //public string idAlmacenActualizar;
        static string rut;
        static string userr;
        DataTable dt5;
        static string qy;
        YoApruebo.BLL.Ingreso ingreso = new YoApruebo.BLL.Ingreso();

        protected void Page_Load(object sender, EventArgs e)
        {
            string queryperfil = "select id_perfil, perfil from Perfil";

            dt5 = ingreso.getPerfil(queryperfil);

            ListItem i;
            listPerfil.Items.Clear();
            foreach (DataRow r in dt5.Rows)
            {
                i = new ListItem(r["perfil"].ToString());
                listPerfil.Items.Add(i);
            }

            List<usuario> lista = traeUsuarios();
           
                DataTable dt = new DataTable();
                GridView1.DataSource = "";
                dt.Columns.AddRange(new DataColumn[11] {new DataColumn("Usuario"), new DataColumn("Perfil"), new DataColumn("Nombre"), new DataColumn("Apellido"), new DataColumn("Rut"), new DataColumn("Cargo"), new DataColumn("Correo"), new DataColumn("Telefono"), new DataColumn("Direccion"), new DataColumn("EstadoUser"), new DataColumn("EstadoPer") });

                foreach (usuario al in lista)
                {
                    //  ListItem li = new ListItem(al.usuarioUsuario, al.id.ToString());
                    
                        String esActivoUser = al.esActivoUser ? "Activo" : "No Activo";
                        String esActivoPer = al.esActivoPer ? "Activo" : "No Activo";
                        dt.Rows.Add(al.usuarioUsuario, al.perfilUsuario, al.nombreUsuario, al.apellidoUsuario, al.rutUsuario + "-" + al.dvUsuario, al.cargoUsuario, al.correoUsuario, al.telefonoUsuario, al.direccionUsuario, esActivoUser, esActivoPer);
                    
                  
                }
                GridView1.DataSource = dt;
                GridView1.DataBind();

               GridView1.HeaderRow.CssClass = "thead-dark";




            
        }


        private void mostrarModal(usuario al)
        {
            lblId.Text = al.id;
            lblModalTitle.Text = "Editando " + al.usuarioUsuario;
            // idAlmacenActualizar = al.id;
            //lblModalBody.Text = "This is modal body";
            txtUsuario.Text = al.usuarioUsuario;
            userr = al.usuarioUsuario;
            txtNombre.Text = al.nombreUsuario;
            txtApellido.Text = al.apellidoUsuario;
            txtRutC.Text = al.rutUsuario + "-" + al.dvUsuario;
            rut = al.rutUsuario;
            txtCargo.Text = al.cargoUsuario;
            txtCorreo.Text = al.correoUsuario;
            txtTelefono.Text = al.telefonoUsuario;
            txtDireccion.Text = al.direccionUsuario;
           chkActivoUser.Checked = al.esActivoUser;
            chkActivoPer.Checked = al.esActivoPer;
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
                    foreach (usuario al in usuarios)
                    {
                        if (al.usuarioUsuario.Equals(row.Cells[0].Text))
                        {

                            mostrarModal(al);
                           // idAlmacenActualizar = al.id;
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
        List<usuario> traeUsuarios()
        {
            usuarios = new List<usuario>();
            if (checkPer.Checked == true && checkUser.Checked == true) {qy = "select id_usuario, Usuario, Perfil, Nombre, Apellido, RUT, DV, Cargo, Correo, Telefono, Direccion, u.estado as u_estado, p.estado as p_estado from usuario u inner join persona p on u.ID_PERSONA = p.ID_PERSONA inner join perfil l on u.ID_PERFIL = l.ID_PERFIL where u.estado = '1' and p.estado = '1'";}
            if (checkPer.Checked == true && checkUser.Checked== false) {qy = "select id_usuario, Usuario, Perfil, Nombre, Apellido, RUT, DV, Cargo, Correo, Telefono, Direccion, u.estado as u_estado, p.estado as p_estado from usuario u inner join persona p on u.ID_PERSONA = p.ID_PERSONA inner join perfil l on u.ID_PERFIL = l.ID_PERFIL where p.estado = '1'"; }
            if (checkPer.Checked == false && checkUser.Checked == true) {qy = "select id_usuario, Usuario, Perfil, Nombre, Apellido, RUT, DV, Cargo, Correo, Telefono, Direccion, u.estado as u_estado, p.estado as p_estado from usuario u inner join persona p on u.ID_PERSONA = p.ID_PERSONA inner join perfil l on u.ID_PERFIL = l.ID_PERFIL where u.estado = '1'"; }
            if (checkPer.Checked == false && checkUser.Checked == false) { qy = "select id_usuario, Usuario, Perfil, Nombre, Apellido, RUT, DV, Cargo, Correo, Telefono, Direccion, u.estado as u_estado, p.estado as p_estado from usuario u inner join persona p on u.ID_PERSONA = p.ID_PERSONA inner join perfil l on u.ID_PERFIL = l.ID_PERFIL"; }

            DataTable tabla = insertarBD.getPerfil(qy);
            usuario usuarioObj;
            for (int i = 0; i <= tabla.Rows.Count - 1; i++)
            {
                string id = tabla.Rows[i]["id_usuario"].ToString();
                string usuario = tabla.Rows[i]["usuario"].ToString();
                string perfil = tabla.Rows[i]["perfil"].ToString();
                // userr = usuario;
                string nombre = tabla.Rows[i]["nombre"].ToString();
                string apellido = tabla.Rows[i]["apellido"].ToString();
                string rutt = tabla.Rows[i]["rut"].ToString();
                string dv = tabla.Rows[i]["dv"].ToString();
                string cargo = tabla.Rows[i]["cargo"].ToString();
                string correo = tabla.Rows[i]["correo"].ToString();
                string telefono = tabla.Rows[i]["telefono"].ToString();
                string direccion = tabla.Rows[i]["direccion"].ToString();
                bool estadouser = tabla.Rows[i]["u_estado"].ToString().Equals("1") ? true : false;
                bool estadoper = tabla.Rows[i]["p_estado"].ToString().Equals("1") ? true : false;
                usuarioObj = new usuario(id, usuario, perfil, nombre, apellido, rutt, dv, cargo, correo, telefono, direccion, estadouser, estadoper);
                usuarios.Add(usuarioObj);
            }
            return usuarios;
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {

        }

        protected void drop1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        usuario traeUsuarios(string idM)
        {
            foreach (usuario al in usuarios)
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
            string activoPer = chkActivoPer.Checked ? "1" : "0";
            string activoUser = chkActivoUser.Checked ? "1" : "0";
            string query = "update Persona set nombre = '" + txtNombre.Text + "', apellido = '" + txtApellido.Text + "', cargo = '" + txtCargo.Text + "', correo = '" + txtCorreo.Text + "', telefono = '" + txtTelefono.Text + "', direccion = '" + txtDireccion.Text + "' , estado = '" + activoPer + "' where rut = '" + rut  + "'";
            ingreso.ingresar(query);
          
            string queryperfil = "select id_perfil from Perfil where perfil = '" + listPerfil.SelectedValue + "'";
            DataTable dt3 = ingreso.getPerfil(queryperfil);

            foreach (DataRow r in dt3.Rows)
            {
            idperfil = r["id_perfil"].ToString();
            }
            string queryuser = "update Usuario set usuario = '" + txtUsuario.Text + "', id_perfil = '" + idperfil + "', estado = '" + activoUser + "' where usuario ='" + userr + "'";
            ingreso.ingresar(queryuser);
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "#myModal", "$('body').removeClass('modal-open');$('.modal-backdrop').remove();", true);
            Response.Redirect(Request.RawUrl);

        }
    }
}