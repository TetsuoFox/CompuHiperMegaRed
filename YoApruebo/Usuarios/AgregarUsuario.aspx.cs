using SuperMundoHiperMegaRed;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace YoApruebo
{
    public partial class _Usuario : Page
    {
        static string rutt;
        string idpersona;
        string idperfil;
        static string userr;
        DataTable dt;
        YoApruebo.BLL.Rut rut = new YoApruebo.BLL.Rut();
        YoApruebo.BLL.Ingreso ingreso = new YoApruebo.BLL.Ingreso();
        protected void Page_Load(object sender, EventArgs e)
        {
            string queryperfil = "select id_perfil, perfil from Perfil";

            dt = ingreso.getPerfil(queryperfil);

            ListItem i;
            listPerfil.Items.Clear();
            foreach (DataRow r in dt.Rows)
            {
                i = new ListItem(r["perfil"].ToString());
                listPerfil.Items.Add(i);
            }
            llenaTabla();
        }

        protected void AgregarUsuario_Click(object sender, EventArgs e)
        {


            if (textPass1.Text.Equals(textPass2.Text))
            {
                string query = "Insert into Persona (nombre, apellido, cargo, correo, telefono, direccion, rut, dv, estado) values ('" + textNombre.Text + "','" + textApellido.Text + "','" + textCargo.Text + "','" + textCorreo.Text + "','" + textTelefono.Text + "','" + textDireccion.Text + "','" + textRut.Text + "','" + textDV.Text + "',1)";
                ingreso.ingresar(query);
                string queryidperso = "select id_persona from persona where rut='" + textRut.Text + "'";
                DataTable dt2 = ingreso.getPerfil(queryidperso);
                foreach (DataRow r in dt2.Rows)
                {
                    idpersona = r["id_persona"].ToString();
                }
                string queryperfil = "select id_perfil from Perfil where perfil = '" + listPerfil.SelectedValue + "'";
                DataTable dt3 = ingreso.getPerfil(queryperfil);

                foreach (DataRow r in dt3.Rows)
                {
                    idperfil = r["id_perfil"].ToString();
                }

                string queryuser = "insert into usuario (usuario, password, id_persona, id_perfil, estado) values ('" + textUsuario.Text + "','" + textPass1.Text + "','" + idpersona + "','" + idperfil + "',1)";
                ingreso.ingresar(queryuser);
                llenaTabla();

            }
            else
            {
                lblAd.Text = "Las Contraseña no coinciden";
                textPass2.CssClass = "form-control is-invalid";
                textPass1.CssClass = "form-control is-invalid";
            }

            if (textRut.Text.Equals(""))
            {
                textRut.CssClass = "form-control is-invalid";
                lblAd2.Text = "Faltan datos por ingresar";
            }
            else
            {

            }
            if (textNombre.Text.Equals(""))
            {
                textNombre.CssClass = "form-control is-invalid";
                lblAd2.Text = "Faltan datos por ingresar";
            }
            if (textApellido.Text.Equals(""))
            {
                textApellido.CssClass = "form-control is-invalid";
                lblAd2.Text = "Faltan datos por ingresar";
            }
            if (textDV.Text.Equals(""))
            {
                textDV.CssClass = "form-control is-invalid";
                lblAd2.Text = "Faltan datos por ingresar";
            }
            if (textCargo.Text.Equals(""))
            {
                textCargo.CssClass = "form-control is-invalid";
                lblAd2.Text = "Faltan datos por ingresar";
            }
            if (textCorreo.Text.Equals(""))
            {
                textCorreo.CssClass = "form-control is-invalid";
                lblAd2.Text = "Faltan datos por ingresar";
            }
            if (textTelefono.Text.Equals(""))
            {
                textTelefono.CssClass = "form-control is-invalid";
                lblAd2.Text = "Faltan datos por ingresar";
            }
            if (textDireccion.Text.Equals(""))
            {
                textDireccion.CssClass = "form-control is-invalid";
                lblAd2.Text = "Faltan datos por ingresar";
            }
            if (textUsuario.Text.Equals(""))
            {
                textUsuario.CssClass = "form-control is-invalid";
                lblAd2.Text = "Faltan datos por ingresar";
            }
            if (textPass1.Text.Equals(""))
            {
                textPass1.CssClass = "form-control is-invalid";
                lblAd2.Text = "Faltan datos por ingresar";
            }
            if (textPass2.Text.Equals(""))
            {
                textPass2.CssClass = "form-control is-invalid";
                lblAd2.Text = "Faltan datos por ingresar";
            }

        }


        protected void textRut_TextChanged(object sender, EventArgs e)
        {

            string query = "SELECT Nombre, apellido, cargo, correo, telefono, direccion, dv FROM persona WHERE rut ='" + textRut.Text + "'";
            DataTable respuesta = ingreso.getPerfil(query);
            foreach (DataRow r in respuesta.Rows)
            {
                textNombre.Text = r["nombre"].ToString();
                textApellido.Text = r["apellido"].ToString();
                textCargo.Text = r["cargo"].ToString();
                textCorreo.Text = r["correo"].ToString();
                textTelefono.Text = r["telefono"].ToString();
                textDireccion.Text = r["direccion"].ToString();
                textDV.Text = r["dv"].ToString();
            }
        }

        public void llenaTabla(String query)
        {

            DataTable tabla = ingreso.getPerfil(query);
            tblUsuario.DataSource = tabla;
            tblUsuario.DataBind();

        }
      

        protected void textRut_Leave(object sender, EventArgs e)
        {



        }

   


        protected void tblUsuario_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            
        }

        protected void ModificarU_Click(object sender, EventArgs e)
        {
            Label1.Text = "solo estoy probando que sucede";
        }
            protected void ModificarUser_Click(object sender, EventArgs e)
        {
            
      //      if (textPass1.Text.Equals(textPass2.Text)) 
      //      {
      //          string query = "update Persona set nombre = '" + textNombre.Text + "', apellido = '" + textApellido.Text + "', cargo = '" + textCargo.Text + "', correo = '" + textCorreo.Text + "', telefono = '" + textTelefono.Text + "', direccion = '" + textDireccion.Text + "' where rut = '" + rutt + "'";
      //          ingreso.ingresar(query);
      //          string queryidperso = "select id_persona from persona where rut='" + rutt + "'";
      //          DataTable dt2 = ingreso.getPerfil(queryidperso);
      //          foreach (DataRow r in dt2.Rows)
      //          {
      //              idpersona = r["id_persona"].ToString();
      //          }
      //          string queryperfil = "select id_perfil from Perfil where perfil = '" + listPerfil.SelectedValue + "'";
      //          DataTable dt3 = ingreso.getPerfil(queryperfil);

      //          foreach (DataRow r in dt3.Rows)
      //          {
      //              idperfil = r["id_perfil"].ToString();
      //          }

      //          string queryuser = "update Usuario set usuario = '" + textUsuario.Text + "', password= '" + textPass1.Text + "', id_persona = '" + idpersona + "', id_perfil = '" + idperfil + "' where usuario ='" + userr + "'";
      //          ingreso.ingresar(queryuser);
      //          llenaTabla(); 
      //          AgregarUsuario.Visible = true;
      //          ModificarUser.Visible = false;
      
      ////          Response.Redirect("Agregarusuario.aspx");
      //       }
      //      else
      //      {
      //          lblAd.Text = "Las Contraseña no coinciden";
      //          textPass2.CssClass = "form-control is-invalid";
      //          textPass1.CssClass = "form-control is-invalid";
      //      }
        }
        public void llenaTabla()
        {
            String query = "select Usuario, Nombre, Apellido, RUT, DV, Cargo, Correo, Telefono, Direccion from usuario u inner join persona p on u.ID_PERSONA = p.ID_PERSONA where u.ESTADO = 1 and p.ESTADO = 1 ";
            DataTable tabla = ingreso.getPerfil(query);
            tblUsuario.DataSource = tabla;
            tblUsuario.DataBind();

        }

        protected void tblUsuario_RowEditing(object sender, GridViewEditEventArgs e)
        {
          
        }

        protected void tblUsuario_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            string usuario = tblUsuario.Rows[e.NewSelectedIndex].Cells[1].Text.ToString();
            userr = usuario;
            string nombre = tblUsuario.Rows[e.NewSelectedIndex].Cells[2].Text.ToString();
            string apellido = tblUsuario.Rows[e.NewSelectedIndex].Cells[3].Text.ToString();
            rutt = tblUsuario.Rows[e.NewSelectedIndex].Cells[4].Text.ToString();
            string dv = tblUsuario.Rows[e.NewSelectedIndex].Cells[5].Text.ToString();
            string cargo = tblUsuario.Rows[e.NewSelectedIndex].Cells[6].Text.ToString();
            string correo = tblUsuario.Rows[e.NewSelectedIndex].Cells[7].Text.ToString();
            string telefono = tblUsuario.Rows[e.NewSelectedIndex].Cells[8].Text.ToString();
            string direccion = tblUsuario.Rows[e.NewSelectedIndex].Cells[9].Text.ToString();
            textUsuario.Text = usuario;
            textNombre.Text = nombre;
            textApellido.Text = apellido;
            textRut.Text = rutt;
            textCargo.Text = cargo;
            textDV.Text = dv;
            textCorreo.Text = correo;
            textTelefono.Text = telefono;
            textDireccion.Text = direccion;
            textUsuario.CssClass = "form-control border-secondary";
            textNombre.CssClass = "form-control border-secondary";
            textApellido.CssClass = "form-control border-secondary";
            textRut.Enabled = false;
            textDV.Enabled = false;
            textUsuario.Enabled = false;
            textCorreo.CssClass = "form-control border-secondary";
            textTelefono.CssClass = "form-control border-secondary";
            textDireccion.CssClass = "form-control border-secondary";
            textPass1.CssClass = "form-control border-secondary";
            textPass2.CssClass = "form-control border-secondary";
            AgregarUsuario.Visible = false;
            ModificarUser.Visible = true;
            delPersona.Visible = true;
            delUsuario.Visible = true;
            textNombre.Focus();
        }

        protected void tblUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
