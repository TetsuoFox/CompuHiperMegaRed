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

            HtmlGenericControl divcollapse = new HtmlGenericControl("div");
            divcollapse.ID = "collapseintento";
            sideBarontainer.Attributes.Add("class", "collapse");
            sideBarontainer.Controls.Add(divcollapse);

            for (int i = 0; i < 3; i++)
            {
                HtmlGenericControl subDiv = new HtmlGenericControl("a");
                subDiv.Attributes.Add("class", "list-group-item list-group-item-action");
                subDiv.Attributes.Add("href", "../Articulos/AgregarArticuloMasv.aspx");
                subDiv.InnerText = "Sub Menu " + i;
                divcollapse.Controls.Add(subDiv);
            }

        }


        private void crearSideBar(string DB_permisos)
        {
            string querys = "asd";
            string allpermit = (querys);

            string[] permits = allpermit.Split('|');

            foreach (string menus in permits)
            {

                HtmlGenericControl Menu = createMenu("asd");
                sideBarontainer.Controls.Add(Menu);

                sideBarontainer.Controls.Add(createDivSubMenusContainer("sd", "asd"));

                string[] submenus = menus.Split(',');

                foreach (string j in submenus)
                {
                    HtmlGenericControl sub_menu = createSubMenu("nombre", "link");
                }

            }
        }

        private HtmlGenericControl createMenu(string name)
        {
            HtmlGenericControl newDiv = new HtmlGenericControl("a");
            newDiv.ID = "newSuperDIV"; //<---Give and ID to the div, very important!
            newDiv.Attributes.Add("class", "list-group-item active");
            newDiv.Attributes.Add("href", "#collapseintento");//<---Apply a css class if wanted
            newDiv.Attributes.Add(" data-toggle", "collapse");
            newDiv.InnerText = "INTENTO";
            return newDiv; //<---Add the new div to our already existing div
        }
        private HtmlGenericControl createSubMenu(string name, string link)
        {
            HtmlGenericControl subDiv = new HtmlGenericControl("a");
            subDiv.Attributes.Add("class", "list-group-item list-group-item-action");
            subDiv.Attributes.Add("href", "../Articulos/AgregarArticuloMasv.aspx");
            subDiv.InnerText = "Sub Menu ";
            return subDiv;
        }
        private HtmlGenericControl createDivSubMenusContainer(string name, string link)
        {
            HtmlGenericControl divSubMenusContainer = new HtmlGenericControl("div");
            divSubMenusContainer.ID = "collapseintento";
            divSubMenusContainer.Attributes.Add("class", "collapse");
            return divSubMenusContainer;
        }
        private string getPermitsUser(string nameUser)
        {
            BD data_base = new BD();
            string query = "SELECT[PERMISOS] FROM[dbo].[PERFIL] INNER JOIN[dbo].[USUARIO] ON[dbo].[USUARIO].[ID_PERFIL] = [dbo].[PERFIL].[ID_PERFIL] WHERE[dbo].[USUARIO].[USUARIO] = '" + nameUser + "';";
            string permits = data_base.   ;
            return permits;
        }
    }
}