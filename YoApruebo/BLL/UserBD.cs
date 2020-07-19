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
    }
}