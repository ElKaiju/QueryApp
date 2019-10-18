using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QueryWebApp
{
    public class MensajeController
    {
        private static List<Mensaje> listaMensajes = new List<Mensaje>();

        public static void CrearMensaje()
        {
            Mensaje m1 = new Mensaje();
            m1._idMensaje = 1;
            m1._tipoMensaje = "Asesor";
            m1._elMensaje = "Necesito imprimir y no puedo!!!!!";

            Mensaje m2 = new Mensaje();
            m2._idMensaje = 2;
            m2._tipoMensaje = "Asesor";
            m2._elMensaje = "No me abre excel y en mi internet explorer aparecen páginas cochinas";

            Mensaje m3 = new Mensaje();
            m3._idMensaje = 3;
            m3._tipoMensaje = "Cliente";
            m3._elMensaje = "no me puedo contactar con un asesor que pasa";

            listaMensajes.Add(m1);
            listaMensajes.Add(m2);
            listaMensajes.Add(m3);
        }

        public static List<Mensaje> GetMensajes()
        {
            return listaMensajes;
        }
       
    }
}