using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QueryWebApp
{
    public class UsuarioController
    {
        private static List<Usuario> listaUsuario = new List<Usuario>();

        public static void crearUsuario()
        {
            listaUsuario.Add(new Usuario(1, "1-1", "admin123", "Carlos", "Santana", 50, "Masculino", 345346234, "admin@query.cl", "admin"));
            listaUsuario.Add(new Usuario(2, "1-2", "asesor123", "María", "LaDelBarrio", 33, "Femenino", 234235235, "asesor@query.cl", "asesor"));
            listaUsuario.Add(new Usuario(3, "1-3", "cliente123", "Hijo", "DeBaphomet", 66, "Masculino", 264534634, "cliente@cliente.cl", "cliente"));

        }

        public static string CrearUsuario2(string id, string rut, string pass, string nom, string ap, string ed, string sx, string num, string mail, string user)
        {
            try
            {
                listaUsuario.Add(new Usuario()
                {
                    _idUsuario = int.Parse(id),
                    _rut = rut,
                    _password = pass,
                    _nombre = nom,
                    _apellido = ap,
                    _edad = int.Parse(ed),
                    _sexo = sx,
                    _telefono = int.Parse(num),
                    _email = mail,
                    _tipoUsuario = user
                   
                });

                return "Usuario agregado con éxito.";
            }
            catch (Exception e)
            {

                return e.ToString();
            }
        }

        public static Usuario buscarUsuario (string rut)
        {
            foreach (Usuario aux in listaUsuario)
            {
                if (aux._rut.Equals(rut))
                {
                    return aux;
                }
            }

            return null;

        }
    }
}