using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using YoApruebo.DAL;

namespace SuperMundoHiperMegaRed
{
    public class SideBar
    {
        public Categories[] category;
        public SideBar(string allpermits)
        {
            if (allpermits.Equals("all"))
                allpermits = getAllPermit();

            string[] permits = allpermits.Split('|');
            category = new Categories[permits.Length];

            for (int i = 0; i < permits.Length; i++)
                category[i] = new Categories(permits[i]);

        }

        public string getAllPermit()
        {
            BD bd = new BD();
            string allpermits = "";
            string query = "SELECT[dbo].[LISTA_PERMISOS].[ID_PERMISO]FROM[dbo].[LISTA_PERMISOS]";
            DataTable allpermitsdatatablea = bd.getDataTable(query, bd.getConexion("SQL"));

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
            allpermits = allpermits.Trim(',','|');
            return allpermits;
        }
    }

    public class Categories
    {
        private string namemenu;
        private string[] namesubmenu;
        private string[] link;

        public Categories(string permits)
        {
            int k = permits.IndexOf('.');
            string idnamemenu = permits.Substring(0, k);
            namemenu = getNameByIdFromDB(idnamemenu);

            string[] idnamesubmenu = permits.Split(',');
            namesubmenu = new string[idnamesubmenu.Length];
            link = new string[idnamesubmenu.Length];

            for (int i = 0; i < idnamesubmenu.Length; i++)
            {
                namesubmenu[i] = getNameByIdFromDB(idnamesubmenu[i]);
                Console.WriteLine(namesubmenu[i]);
                link[i] = getLinkByIdFromDB(idnamesubmenu[i]);
                Console.WriteLine(link[i]);
            }

        }

        public string getNameByIdFromDB(string id)
        {
            BD bd = new BD();
            string query = "SELECT[dbo].[LISTA_PERMISOS].[NOMBRE]FROM[dbo].[LISTA_PERMISOS]WHERE[dbo].[LISTA_PERMISOS].[ID_PERMISO] = '" + id + "';";
            string name = bd.getResultQueryLikeString(query);
            return name;
        }
        public string getLinkByIdFromDB(string id)
        {
            BD bd = new BD();
            string query = "SELECT[dbo].[LISTA_PERMISOS].[LINK]FROM[dbo].[LISTA_PERMISOS]WHERE[dbo].[LISTA_PERMISOS].[ID_PERMISO] = '" + id + "';";
            string link = bd.getResultQueryLikeString(query);
            return link;
        }
        public string getNameCategory()
        {
            return namemenu;
        }
        public string[] getSubNameCategory()
        {
            return namesubmenu;
        }
        public string[] getLinkCategory()
        {
            return link;
        }

    }
}
