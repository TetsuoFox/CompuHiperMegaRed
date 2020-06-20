using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace YoApruebo.BLL
{
    public class Rut
    {
        DAL.BD bd = new DAL.BD();

        public DataTable getRut(String query, string rut)
        {
            DataTable dt = bd.getDataTable(query, bd.getConexion("SQL"));
            
            if (rut.Equals(dt.Rows[0][1].ToString()))
            {
                return dt;
            }
            else
            {
                return dt;
            }
        }
    }
}