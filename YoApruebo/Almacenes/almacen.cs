using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SuperMundoHiperMegaRed.Almacenes
{
    

    public class almacen
    {
      public  string id;
        public String nombreAlmacen;
      public  bool esActivo = false;

        public almacen(String nombre, bool estado, string idM)
        {
            nombreAlmacen = nombre;
            esActivo = estado;
            id = idM;
        }

        public almacen(String nombre, string idM)
        {
            nombreAlmacen = nombre;
            id = idM;
        }


    }
}