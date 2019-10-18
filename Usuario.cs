using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QueryWebApp
{
    public class Usuario
    {
        private int idUsuario;
        private string rut;
        private string password;
        private string nombre;
        private string apellido;
        private int edad;
        private string sexo;
        private int telefono;
        private string email;
        private string tipoUsuario;

        public Usuario()
        {
        }

        public Usuario(int idUsuario, string rut, string password, string nombre, string apellido, int edad, string sexo, int telefono, string email, string tipoUsuario)
        {
            this.idUsuario = idUsuario;
            this.rut = rut;
            this.password = password;
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.sexo = sexo;
            this.telefono = telefono;
            this.email = email;
            this.tipoUsuario = tipoUsuario;
        }

        public int _idUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        public string _rut
        {
            get { return rut; }
            set { rut = value; }
        }

        public string _password
        {
            get { return password; }
            set { password = value; }
        }

        public string _nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string _apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public int _edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public string _sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public int _telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string _email
        {
            get { return email; }
            set { email = value; }
        }

        public string _tipoUsuario
        {
            get { return tipoUsuario; }
            set { tipoUsuario = value; }
        }

    }
}