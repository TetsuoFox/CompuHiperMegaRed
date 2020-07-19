using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using YoApruebo.DAL;

namespace SuperMundoHiperMegaRed
{
    public partial class PaginaMaestra : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (HttpContext.Current.Session["authorized"].Equals("NO"))
            {
                Response.Redirect("~/index.aspx");
            }
            createSideBar();
            createNavBar();
        }

        private void createSideBar()
        {
            string allpermits = getPermitsUser("jacob");//necesitas hacer session
            SideBar sidebar = new SideBar(allpermits);

            for (int i = 0; i < sidebar.category.Length; i++)
            {
                string namemenu = sidebar.category[i].getNameCategory();
                string idcategory = namemenu.Replace(" ", string.Empty) + "collapse";
                HtmlGenericControl etiquetamenu = createMenu(namemenu, idcategory);
                sidebarcontainer.Controls.Add(etiquetamenu);

                HtmlGenericControl divsubmenuscontainer = createDivSubmenusContainer(idcategory);
                sidebarcontainer.Controls.Add(divsubmenuscontainer);

                string[] namesubmenu = sidebar.category[i].getSubNameCategory();
                string[] linksubmenu = sidebar.category[i].getLinkCategory();

                for (int j = 0; j < namesubmenu.Length; j++)
                {
                    HtmlGenericControl eqiquetasubmenu = createSubMenu(namesubmenu[j], linksubmenu[j]);
                    divsubmenuscontainer.Controls.Add(eqiquetasubmenu);
                }
            }

        }
        private HtmlGenericControl createMenu(string namemenu, string idcategory)
        {
            HtmlGenericControl newDiv = new HtmlGenericControl("a");
            newDiv.ID = "menu";
            newDiv.Attributes.Add("class", "list-group-item active");
            newDiv.Attributes.Add("href", ("#" + idcategory));
            newDiv.Attributes.Add(" data-toggle", "collapse");
            newDiv.InnerText = namemenu;
            return newDiv;
        }
        private HtmlGenericControl createDivSubmenusContainer(string idcategory)
        {
            HtmlGenericControl divSubMenusContainer = new HtmlGenericControl("div");
            divSubMenusContainer.ID = idcategory;
            divSubMenusContainer.Attributes.Add("class", "collapse");
            return divSubMenusContainer;
        }
        private HtmlGenericControl createSubMenu(string name, string link)
        {
            HtmlGenericControl subDiv = new HtmlGenericControl("a");
            subDiv.Attributes.Add("class", "list-group-item list-group-item-action");
            subDiv.Attributes.Add("href", link);
            subDiv.InnerText = name;
            return subDiv;
        }
        private string getPermitsUser(string nameUser)
        {
            BD data_base = new BD();
            string query = "SELECT[PERMISOS] FROM[dbo].[PERFIL] INNER JOIN[dbo].[USUARIO] ON[dbo].[USUARIO].[ID_PERFIL] = [dbo].[PERFIL].[ID_PERFIL] WHERE[dbo].[USUARIO].[USUARIO] = '" + nameUser + "';";
            string permits = data_base.getResultQueryLikeString(query);
            return permits;
        }
        private string getNameMenu(string permit)
        {
            return "";
        }

        public void createNavBar()
        {
            nombre_empresa.InnerHtml = "CompuMundo";
            opcion_uno.InnerHtml = "Opcion1";
            opcion_dos.InnerHtml = "Opcion2";
            string name = Session["name"].ToString() + " " + Session["lastname"].ToString();
            nameuser.InnerHtml = name;
        }
    }
}