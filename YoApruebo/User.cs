using SuperMundoHiperMegaRed.BLL;

namespace SuperMundoHiperMegaRed
{
    public class Persona
    {

        private string name, lastname, cargo, telefono, direccion, estado;

        public Persona(string nickname)
        {
            UserBD userdb = new UserBD();
            name =      userdb.getValueFromBD("NOMBRE", nickname);
            lastname =  userdb.getValueFromBD("APELLIDO", nickname);
            cargo =     userdb.getValueFromBD("CARGO", nickname);
            telefono =  userdb.getValueFromBD("TELEFONO", nickname);
            direccion = userdb.getValueFromBD("DIRECCION", nickname);
            estado =    userdb.getValueFromBD("ESTADO", nickname);
        }

        public string getName() { return name; }
        public string getLastname() { return lastname; }
        public string getCargo() { return cargo; }
        public string getTelefono() { return telefono; }
        public string getDireccion() { return direccion; }
        public string getEstado() { return estado; }

    }
}

