using System.Data;

namespace YoApruebo.BLL
{
    public class Login
    {
        DAL.BD bd = new DAL.BD();

        public bool authenticaticateUser(string user, string pass)
        {
            string query = "SELECT USUARIO, PASSWORD FROM USUARIO WHERE USUARIO ='" + user + "';";
            bool respuesta = getUseryPass(query, pass);
            return respuesta;
        }

        public bool getUseryPass (string query, string password)
        {
            DataTable dt = bd.getDataTable(query, bd.getConexion("SQL"));
            
            //comprueba si la query obtuvo resultados.
            if (dt.Rows.Count > 0)
            {
                if (password.Equals(dt.Rows[0][1].ToString()))
                    return true;
                return false;
            }
            return false;
        }
    }
}