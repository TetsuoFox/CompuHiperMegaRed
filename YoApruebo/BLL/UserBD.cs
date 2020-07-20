using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using YoApruebo.DAL;

namespace SuperMundoHiperMegaRed.BLL
{
    public class UserBD
    {
        BD bd = new BD();
        public string getValueFromBD(string columnname, string nickname)
        {
            string query = "  SELECT [dbo].[PERSONA].[" + columnname + "] from [dbo].[PERSONA] INNER JOIN [dbo].[USUARIO] ON[dbo].[PERSONA].[ID_PERSONA] = [dbo].[USUARIO].[ID_PERSONA] WHERE[USUARIO] = '" + nickname + "'; ";
            string a = bd.getResultQueryLikeString(query); 
            return a;
        }
        public string getListPermits(string nickname)
        {
            BD data_base = new BD();
            string query = "SELECT[PERMISOS] FROM[dbo].[PERFIL] INNER JOIN[dbo].[USUARIO] ON[dbo].[USUARIO].[ID_PERFIL] = [dbo].[PERFIL].[ID_PERFIL] WHERE[dbo].[USUARIO].[USUARIO] = '" + nickname + "';";
            string permits = data_base.getResultQueryLikeString(query);
            return permits;
        }
    }
}