using YoApruebo.DAL;

namespace SuperMundoHiperMegaRed.BLL
{
    public class UserDB
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
            string query = "SELECT[PERMISOS] FROM[dbo].[PERFIL] INNER JOIN[dbo].[USUARIO] ON[dbo].[USUARIO].[ID_PERFIL] = [dbo].[PERFIL].[ID_PERFIL] WHERE[dbo].[USUARIO].[USUARIO] = '" + nickname + "';";
            string permits = bd.getResultQueryLikeString(query);
            return permits;
        }
    }
}