using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Threading.Tasks;


namespace YoApruebo.DAL
{
    public class BD
    {
        string ipServer = @"sql5046.site4now.net";//@"18.217.105.148\PRODUCCION";
        string databaseName = "DB_A62E4D_inacap2020";//"inacap";
        public string getConexion(string tipo)
        {
            switch (tipo)
            {
                case "SQL":
                    return "Server=" + ipServer + ";Database=" + databaseName + ";User Id=DB_A62E4D_inacap2020_admin;Password=Lindi2020;";//";User Id=vcastro;Password=victor2020;";
                                                                                                                                          //return "Server=" + ipServer + ";Database=" + databaseName + ";Trusted_Connection=True;;";
                case "ORACLE":
                    return "";
                default:
                    return "";
            }
        }

        public DataTable getDataTable(string query, string con)
        {
            /*Invocamos la Conexión*/
            SqlConnection conexion = new SqlConnection(con);
            /*Pasamos el Sql Connection + la Query*/
            SqlDataAdapter da = new SqlDataAdapter(query, conexion);
            /*Creamos el DataTable*/
            DataTable dt = new DataTable();
            /*lo Llenamos*/
            try
            {
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            /*retornamos el DT*/
            return dt;
        }

        public void ejecutarQuery(string query, string con)
        {
            SqlConnection conexion = new SqlConnection(con);
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public string getResultQueryLikeString(string query)
        {
            BD database = new BD();
            DataTable dt = database.getDataTable(query, database.getConexion("SQL"));
            string permists = dt.Rows[0][0].ToString();
            return permists;
        }

    }
}
