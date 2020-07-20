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
            if (Session["name"].Equals(""))
                Response.Redirect("~/index.aspx");

            createSideBar(Session["nickname"].ToString());
            createNavBar();
        }
        private void createSideBar(string nickname)
        {
            string permitslist = BLL.UserBD.getListPermits(nickname);
            SideBar sidebar = new SideBar(permitslist);
            createHtmlSideBar(sidebar);
        }

        public void createHtmlSideBar(SideBar sidebar)
        {

            for (int i = 0; i < sidebar.category.Length; i++)
            {
                string categoryname = sidebar.category[i].getNameCategory();
                string idcategory = sidebar.category[i].getIdCategory();
                string[] namesubmenu = sidebar.category[i].getSubNameCategory();
                string[] linksubmenu = sidebar.category[i].getLinkCategory();

                HtmlGenericControl etiquetamenu = createCategory(categoryname, idcategory);
                sidebarcontainer.Controls.Add(etiquetamenu);

                HtmlGenericControl divsubmenuscontainer = createDivSubmenusContainer(idcategory);
                sidebarcontainer.Controls.Add(divsubmenuscontainer);

                for (int j = 0; j < namesubmenu.Length; j++)
                {
                    HtmlGenericControl eqiquetasubmenu = createSubMenu(namesubmenu[j], linksubmenu[j]);
                    divsubmenuscontainer.Controls.Add(eqiquetasubmenu);
                }
            }
        }

        private HtmlGenericControl createCategory(string namemenu, string idcategory)
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

        public void createNavBar()
        {
            nombre_empresa.InnerHtml = "CompuMundo";
            opcion_uno.InnerHtml = "Opcion1";
            opcion_dos.InnerHtml = "Opcion2";
            string name = Session["name"].ToString() + " " + Session["lastname"].ToString();
            nameuser.InnerHtml = name;
        }
        void nameuser_Click(Object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("~/index.aspx");
        }
    }
}