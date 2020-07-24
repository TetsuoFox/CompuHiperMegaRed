using SuperMundoHiperMegaRed.BLL;
using System;
using System.Web.UI.HtmlControls;

namespace SuperMundoHiperMegaRed
{
    public partial class PaginaMaestra : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["nickname"]==null)
                Response.Redirect("~/index.aspx");

            createSideBar(Session["nickname"].ToString());
            createNavBar();

            if (IsPostBack)
            {
              
            }
        }
        private void createSideBar(string nickname)
        {
            UserDB userbd = new UserDB();
            string permitslist = userbd.getListPermits(nickname);

            SideBar sidebar = new SideBar(permitslist);
            createHtmlSideBar(sidebar);
        }
        private void createNavBar()
        {
            string nameuser = Session["name"].ToString() + " " + Session["lastname"].ToString();
            hiuser.InnerHtml = "Hi " + nameuser;
            nombrempresa.InnerHtml = "CompuMundo";
            //btncerrarsesion.InnerHtml = "Cerrar sesión";
        }
        private void createHtmlSideBar(SideBar sidebar)
        {
            for (int i = 0; i < sidebar.category.Length; i++)
            {
                string categoryname = sidebar.category[i].getNameCategory();
                string categoryid = sidebar.category[i].getIdCategory();
                string[] namesubmenu = sidebar.category[i].getSubNameCategory();
                string[] linksubmenu = sidebar.category[i].getLinkCategory();

                sidebarcontainer.Controls.Add(createHtmlCategory(categoryname, categoryid));

                HtmlGenericControl divsubmenuscontainer = createDivSubmenusContainer(categoryid);
                sidebarcontainer.Controls.Add(divsubmenuscontainer);

                for (int j = 0; j < namesubmenu.Length; j++)
                {
                    HtmlGenericControl eqiquetasubmenu = createHtmlSubMenu(namesubmenu[j], linksubmenu[j]);
                    divsubmenuscontainer.Controls.Add(eqiquetasubmenu);
                }
            }
        }
        private HtmlGenericControl createHtmlCategory(string namemenu, string idcategory)
        {
            HtmlGenericControl newDiv = new HtmlGenericControl("a");
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
        private HtmlGenericControl createHtmlSubMenu(string name, string link)
        {
            HtmlGenericControl subDiv = new HtmlGenericControl("a");
            subDiv.Attributes.Add("class", "list-group-item list-group-item-action");
            subDiv.Attributes.Add("href", link);
            subDiv.InnerText = name;
            return subDiv;
        }

        protected void btncerrarsesion_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("~/index.aspx");
        }
    }
}