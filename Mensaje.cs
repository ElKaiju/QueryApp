using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QueryWebApp
{
    public class Mensaje
    {
        private int idMensaje;
        private string tipoMensaje;
        private string elMensaje;

        public Mensaje()
        {
        }

        public Mensaje(int idMensaje, string tipoMensaje, string elMensaje)
        {
            this.idMensaje = idMensaje;
            this.tipoMensaje = tipoMensaje;
            this.elMensaje = elMensaje;
        }

        public int _idMensaje
        {
            get { return idMensaje; }
            set { idMensaje = value; }
        }

        public string _tipoMensaje
        {
            get { return tipoMensaje; }
            set { tipoMensaje = value; }
        }

        public string _elMensaje
        {
            get { return elMensaje; }
            set { elMensaje = value; }
        }

    }
}       