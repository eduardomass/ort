using Servidor.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Servidor.Controllers
{

    public class LoginController : Controller
    {
        public static List<Usuario> lista = new List<Usuario>();

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login(string Nombre)
        {
            Usuario usuarioNuevo = new Usuario();
            usuarioNuevo.Nombre = Nombre;
            usuarioNuevo.Mensajes.Add("Esto es una preba! para " + Nombre);
            LoginController.lista.Add(usuarioNuevo);
            Session["UsuarioLogueado"] = usuarioNuevo;
            return RedirectToAction("Logueados");
        }
        public ActionResult Logueados()
        {
            //ViewBag
            //ViewData
            
            ViewBag.UsuarioLogueador = Session["UsuarioLogueado"];
            ViewBag.Usuarios = LoginController.lista;
            return View();
        }

        public ActionResult EnviarMensaje(string Mensaje, string UsuarioSeleccionado)
        {
            var usuaarioAQuienMandoMensaje = 
                LoginController.lista.Where(o => o.Nombre == UsuarioSeleccionado).FirstOrDefault();

            usuaarioAQuienMandoMensaje.Mensajes.Add(Mensaje);

            return RedirectToAction("Logueados");
        }
    }
}