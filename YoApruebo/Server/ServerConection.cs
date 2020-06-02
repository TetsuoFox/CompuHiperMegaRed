using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices;
using System.Data.SqlClient;

namespace YoApruebo.Server
{
    public partial class ServerConection
    {
        public static String NombreCompleto, NTusername, version;

        string mensaje_error;

        bool status = false;

        string co = string.Empty;
        private bool AutenticatheUser(String userName, String password)
        {
            bool ret = false;

            try
            {
                DirectoryEntry de = new DirectoryEntry(GetCurrentDomainPath(), userName, password);
                DirectorySearcher dsearch = new DirectorySearcher(de);
                dsearch.Filter = "sAMAccountName=" + userName + "";
                SearchResult results = null;

                results = dsearch.FindOne();

                NombreCompleto = results.GetDirectoryEntry().Properties["DisplayName"].Value.ToString();
                NTusername = results.GetDirectoryEntry().Properties["sAMAccountName"].Value.ToString();
                co = results.GetDirectoryEntry().Properties["department"].Value.ToString();//department
                if (GetNTuser(NTusername))
                {
                    ret = true;
                }
                else
                {
                    mensaje_error = "La información proporcionada en correcta,\n pero su usuario no tiene permiso para utilizar el sistema.\nFavor de contactar al administrador del Sistema.";
                }
            }
            catch (Exception ex)
            {
                ret = false;
                mensaje_error = ex + " Error";
            }

            return ret;

        }
        private string GetCurrentDomainPath()
        {
            DirectoryEntry de = new DirectoryEntry("LDAP://ROOTDSE");
            return "LDAP://" + de.Properties["defaultNamingContext"][0].ToString();
        }

        public bool GetNTuser(string NTuserAD)
        {
            SqlConnection conn = new SqlConnection("conexion");
            SqlCommand queryNT = new SqlCommand("SELECT * FROM Usuarios WHERE NTUser ='" + NTuserAD + "' and Permisos = " + 1 + "", conn);
            SqlDataReader ReaderNT;
            conn.Open();
            ReaderNT = queryNT.ExecuteReader();
            if (ReaderNT.Read())
            {
                status = true;

            }
            else
            {
                status = false;
            }
            return status;
        }
    }

}