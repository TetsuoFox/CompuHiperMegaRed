using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SuperMundoHiperMegaRed.Usuarios
{
    public class usuario
    {
         
        public String id;
        public String perfilUsuario;
        public String usuarioUsuario;
        public String nombreUsuario;
        public String apellidoUsuario;
        public String rutUsuario;
        public String dvUsuario;
        public String cargoUsuario;
        public String correoUsuario;
        public String telefonoUsuario;
        public String direccionUsuario;
        public bool esActivoUser = false;
        public bool esActivoPer = false;

        public usuario(string idM, String usuario, String perfil, String nombre, String apellido, String rut, String dv, String cargo, String correo, String telefono, String Direccion, bool estadoUser, bool estadoPer)
        {
            usuarioUsuario = usuario;
            perfilUsuario = perfil;
            nombreUsuario = nombre;
            apellidoUsuario = apellido;
            rutUsuario = rut;
            dvUsuario = dv;
            cargoUsuario = cargo;
            correoUsuario = correo;
            telefonoUsuario = telefono;
            direccionUsuario = Direccion;
            esActivoUser = estadoUser;
            esActivoPer = estadoPer;
            id = idM;
        }

        public usuario(String nombre, String apellido, String rut, String dv, String cargo, String correo, String telefono, String Direccion, string idM)
        {
            nombreUsuario = nombre;
            apellidoUsuario = apellido;
            rutUsuario = rut;
            dvUsuario = dv;
            cargoUsuario = cargo;
            correoUsuario = correo;
            telefonoUsuario = telefono;
            direccionUsuario = Direccion;
            id = idM;
        }
    }
}