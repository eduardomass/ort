using Servidor.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Servidor.Reglas
{
    public static class RNUsuario
    {
        private static List<Usuario> bdUsuario = new List<Usuario>();

        public static List<Usuario> Buscar()
        {
            return bdUsuario;
        }

        public static Usuario Buscar(int id)
        {
            var usuarioEnLista = bdUsuario.Where(usu => usu.Id == id).FirstOrDefault();
            return usuarioEnLista;
        }
        public static void Eliminar(int id)
        {
            var usuarioEnLista = bdUsuario.Where(usu => usu.Id == id).FirstOrDefault();
            bdUsuario.Remove(usuarioEnLista);
        }
        public static Usuario Editar(Usuario usuario)
        {
            var usuarioEnLista = bdUsuario.Where(usu => usu.Id == usuario.Id).FirstOrDefault();
            usuarioEnLista.Nombre = usuario.Nombre;
            usuarioEnLista.Apellido = usuario.Apellido;
            usuarioEnLista.Password = usuario.Password;
            usuarioEnLista.Activo = usuario.Activo;

            return usuarioEnLista;
        }
        public static Usuario ObtenerUsuarioActivo(string nombreIN, string passwordIN)
        {
            var usuarioEncontrado = bdUsuario.Where(usu => usu.Password == passwordIN &&
            usu.NombreUsuario == nombreIN).FirstOrDefault();
            return usuarioEncontrado;
            //foreach (Usuario usuario in bdUsuario)
            //{
            //    if (usuario.NombreUsuario == nombreIN &&
            //        usuario.Password == passwordIN)
            //    {
            //        return usuario;
            //    }
            //}
            //return null;
        }
        public static void AgregarUsaurio(Usuario usuario)
        {
            usuario.Id = bdUsuario.Count + 1;
            bdUsuario.Add(usuario);
            //Agrega al base de datos un usuario
            //Validar que no exista el nombre de usuario!
            //if existe el nombre de usuario dentro de la lista que estoy agregando, entonces
            //throw new Exception("usted no puede agregar!!!");
            //throw new Exception("Error");
        }
    }
}