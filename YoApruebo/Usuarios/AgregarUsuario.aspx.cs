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
    public partial class _Usuario: Page
    {
        string idpersona;
        string idperfil;
        DataTable dt; 
        YoApruebo.BLL.Rut rut = new YoApruebo.BLL.Rut();
        YoApruebo.BLL.Ingreso ingreso = new YoApruebo.BLL.Ingreso();
        protected void Page_Load(object sender, EventArgs e)
        { 
            string queryperfil = "select id_perfil, perfil from Perfil";
            
            dt = ingreso.getPerfil(queryperfil);
            dt.Clear();
            ListItem i;
            foreach (DataRow r in dt.Rows)
            {
                i = new ListItem(r["perfil"].ToString());
                listPerfil.Items.Add(i);
            }
        }

        protected void AgregarUsuario_Click(object sender, EventArgs e)
        {
            

            if (textPass1.Text.Equals(textPass2.Text))
            {
                string query = "Insert into Persona (nombre, apellido, cargo, correo, telefono, direccion, rut, dv, estado) values ('"+textNombre.Text+"','"+textApellido.Text+"','"+textCargo.Text+"','"+textCorreo.Text+"','"+textTelefono.Text+"','"+textDireccion.Text+"','"+textRut.Text+"','"+textDV.Text+"',1)";
                ingreso.ingresar(query);
                string queryidperso = "select id_persona from persona where rut='" + textRut.Text + "'";
                DataTable dt2 = ingreso.getPerfil(queryidperso);
                foreach (DataRow r in dt2.Rows)
                {
                   idpersona = r["id_persona"].ToString();
                }
                string queryperfil = "select id_perfil from Perfil where perfil = '"+listPerfil.SelectedValue+"'";
                DataTable dt3 = ingreso.getPerfil(queryperfil);

                foreach (DataRow r in dt3.Rows)
                {
                    idperfil = r["id_perfil"].ToString();
                }

                string queryuser = "insert into usuario (usuario, password, id_persona, id_perfil, estado) values ('" + textUsuario.Text + "','" + textPass1.Text + "','" + idpersona + "','" + idperfil + "',1)";
                ingreso.ingresar(queryuser);
            }
            else {
                lblAd.Text = "Las Contraseña no coinciden";
                textPass2.CssClass = "form-control is-invalid";
                textPass1.CssClass = "form-control is-invalid";
            }

            if (textRut.Text.Equals(""))
            {
                textRut.CssClass = "form-control is-invalid";
                lblAd2.Text = "Faltan datos por ingresar";
            }
            else { 
            
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

        protected void textRut_Leave(object sender, EventArgs e)
        {
            


        }
    }
        
    }
