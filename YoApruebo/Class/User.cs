using SuperMundoHiperMegaRed.BLL;

namespace SuperMundoHiperMegaRed
{
    public class Persona
    {
        public readonly string name, lastname, cargo, telefono, direccion, estado ;

        public Persona(string nickname)
        {
            UserDB userdb = new UserDB();

            name =      userdb.getValueFromBD("NOMBRE", nickname);
            lastname =  userdb.getValueFromBD("APELLIDO", nickname);
            cargo =     userdb.getValueFromBD("CARGO", nickname);
            telefono =  userdb.getValueFromBD("TELEFONO", nickname);
            direccion = userdb.getValueFromBD("DIRECCION", nickname);
            estado =    userdb.getValueFromBD("ESTADO", nickname);
        }
    }
}

