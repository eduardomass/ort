using Servidor.Datos;
using Servidor.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Servidor.Reglas
{
    public static class RNUsuario
    {
        

        public static List<Usuario> Buscar()
        {
            //return BaseDeDatos.Usuarios;
            using (var bd = new BaseDatosContext())
            {
                return bd.Usuarios.ToList();
            }
        }

        public static Usuario Buscar(int id)
        {
            using (var bd = new BaseDatosContext())
            {
                return RNUsuario.Buscar(id, bd);
            }
        }
        public static Usuario Buscar(int id, 
            BaseDatosContext bd)
        {
                return bd.Usuarios
                    .Where(usu => usu.Id == id)
                    .FirstOrDefault();
        }
        public static void Eliminar(int id)
        {
            var usuario1 = RNUsuario.Buscar(id);
            using (var bd = new BaseDatosContext())
            {
                var usuario1 = RNUsuario.Buscar(id, bd);
                var usuarioAEliminar = 
                    bd.Usuarios.Where(o=>o.Id == id).FirstOrDefault();
                //bd.Usuarios.Remove(usuarioAEliminar);
                bd.Usuarios.Remove(usuario1);
                bd.SaveChanges();
            }
            //    var usuarioEnLista = BaseDeDatos.Usuarios.Where(usu => usu.Id == id).FirstOrDefault();
            //BaseDeDatos.Usuarios.Remove(usuarioEnLista);
        }
        public static Usuario Editar(Usuario usuario)
        {

            using (var bd = new BaseDatosContext())
            {
                var usuarioEnLista =
                    bd.Usuarios.Where(o => o.Id == usuario.Id).FirstOrDefault();
                usuarioEnLista.Nombre = usuario.Nombre;
                usuarioEnLista.Apellido = usuario.Apellido;
                usuarioEnLista.Password = usuario.Password;
                usuarioEnLista.Activo = usuario.Activo;
                bd.SaveChanges();
                return usuarioEnLista;
            }

            //var usuarioEnLista = BaseDeDatos.Usuarios.Where(usu => usu.Id == usuario.Id).FirstOrDefault();
            //usuarioEnLista.Nombre = usuario.Nombre;
            //usuarioEnLista.Apellido = usuario.Apellido;
            //usuarioEnLista.Password = usuario.Password;
            //usuarioEnLista.Activo = usuario.Activo;
            //return usuarioEnLista;
        }
        public static Usuario ObtenerUsuarioActivo(string nombreIN, string passwordIN)
        {
            var usuarioEncontrado = BaseDeDatos.Usuarios.Where(usu => usu.Password == passwordIN &&
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
            using (var bd = new BaseDatosContext())
            {
                bd.Usuarios.Add(usuario);
                bd.SaveChanges();
            }

            //usuario.Id = BaseDeDatos.Usuarios.Count + 1;
            //BaseDeDatos.Usuarios.Add(usuario);


            //Agrega al base de datos un usuario
            //Validar que no exista el nombre de usuario!
            //if existe el nombre de usuario dentro de la lista que estoy agregando, entonces
            //throw new Exception("usted no puede agregar!!!");
            //throw new Exception("Error");
        }
    }
}