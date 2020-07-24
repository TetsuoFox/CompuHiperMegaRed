using System.Data;
using YoApruebo.DAL;

namespace SuperMundoHiperMegaRed.BLL
{
    public class SideBarDB
    {
        BD db = new BD();
        public string getNameByIdFromDB(string id)
        {
            string query = "SELECT[dbo].[LISTA_PERMISOS].[NOMBRE]FROM[dbo].[LISTA_PERMISOS]WHERE[dbo].[LISTA_PERMISOS].[ID_PERMISO] = '" + id + "';";
            string name = db.getResultQueryLikeString(query);
            return name;
        }
        public string getLinkByIdFromDB(string id)
        {
            string query = "SELECT[dbo].[LISTA_PERMISOS].[LINK]FROM[dbo].[LISTA_PERMISOS]WHERE[dbo].[LISTA_PERMISOS].[ID_PERMISO] = '" + id + "';";
            string link = db.getResultQueryLikeString(query);
            return link;
        }
        public string getAllPermit()
        {
            string allpermits = "";
            string query = "SELECT[dbo].[LISTA_PERMISOS].[ID_PERMISO]FROM[dbo].[LISTA_PERMISOS]";
            DataTable allpermitsdatatablea = db.getDataTable(query, db.getConexion("SQL"));

            for (int i = 0; i < allpermitsdatatablea.Rows.Count; i++)
            {
                if (allpermitsdatatablea.Rows[i][0].ToString().Contains("."))
                {
                    allpermits = allpermits + allpermitsdatatablea.Rows[i][0].ToString() + ",";
                }
                else
                {
                    allpermits = allpermits.Trim(',');
                    allpermits = allpermits + "|";
                }
            }
            allpermits = allpermits.Trim(',', '|');
            return allpermits;
        }
    }
}