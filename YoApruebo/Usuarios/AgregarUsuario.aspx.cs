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
        YoApruebo.BLL.Rut rut = new YoApruebo.BLL.Rut();
        YoApruebo.BLL.Ingreso ingreso = new YoApruebo.BLL.Ingreso();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AgregarUsuario_Click(object sender, EventArgs e)
        {
            if (textPass1.Text.Equals(textPass2.Text))
            {
                string query = "Insert into Persona (nombre, apellido, cargo, correo, telefono, direccion, rut, dv, estado) values ('"+textNombre.Text+"','"+textApellido.Text+"','"+textCargo.Text+"','"+textCorreo.Text+"','"+textTelefono.Text+"','"+textDireccion.Text+"','"+textRut.Text+"','"+textDV.Text+",1";
                ingreso.ingresar(query);
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
         //  string query = "SELECT Nombre, apellido, cargo, correo, telefono, direccion FROM persona WHERE rut ='" + textRut.Text + "'";
          // DataTable respuesta = rut.getRut(query, textRut.Text);

           // textNombre.Text = respuesta.Rows[0][1].ToString();

        }
    }
}