using SuperMundoHiperMegaRed.BLL;
using System;

namespace SuperMundoHiperMegaRed
{
    public class SideBar
    {
        private readonly SideBarDB sidebarbd;
        public Categories[] category;
        public SideBar(string permitslist)
        {
            sidebarbd  = new SideBarDB();

            if (permitslist.Equals("all"))
                permitslist = sidebarbd.getAllPermit();

            string[] permits = permitslist.Split('|');
            category = new Categories[permits.Length];

            for (int i = 0; i < permits.Length; i++)
                category[i] = new Categories(permits[i]);

            sidebarbd = null;
        }
    }

    public class Categories
    {
        private readonly string   categoryname;
        private readonly string   categoryid;
        private readonly string[] subcategoryid;
        private readonly string[] subcategorlink;
        private readonly string[] subcategoryname;

        public Categories(string permits)
        {
            SideBarDB sidebardb = new SideBarDB();
            
            int k = permits.IndexOf('.');
            string idnamemenu = permits.Substring(0, k);

            categoryname = sidebardb.getNameByIdFromDB(idnamemenu);
            categoryid = categoryname.ToString().Replace(" ", string.Empty) + "collapse";
            subcategoryid = permits.Split(',');

            subcategoryname = new string[subcategoryid.Length];
            subcategorlink = new string[subcategoryid.Length];
            for (int i = 0; i < subcategoryid.Length; i++)
            {
                subcategoryname[i] = sidebardb.getNameByIdFromDB(subcategoryid[i]);
                Console.WriteLine(subcategoryname[i]);
                subcategorlink[i] = sidebardb.getLinkByIdFromDB(subcategoryid[i]);
                Console.WriteLine(subcategorlink[i]);
            }
        }
        public string getNameCategory()
        {
            return categoryname;
        }
        public string getIdCategory()
        {
            return categoryid;
        }
        public string[] getSubNameCategory()
        {
            return subcategoryname;
        }
        public string[] getLinkCategory()
        {
            return subcategorlink;
        }
    }
}
