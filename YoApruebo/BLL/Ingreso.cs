using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using YoApruebo.DAL;

namespace YoApruebo.BLL
{
    public class Ingreso
    {

        DAL.BD bd = new DAL.BD();

        public void ingresar(String query)
        {
            bd.ejecutarQuery(query, bd.getConexion("SQL"));
        }

        public DataTable getPerfil(String query)
        {
            DataTable dt = bd.getDataTable(query, bd.getConexion("SQL"));
            return dt;
        }
    }
}