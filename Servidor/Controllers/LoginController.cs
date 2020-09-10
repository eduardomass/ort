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
        public static List<string> lista = new List<string>();

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login(string Nombre)
        {
            //ViewBag
            //ViewData
            LoginController.lista.Add(Nombre);
            //return View("Logueados");
            ViewBag.Usuario = Nombre;
            return RedirectToAction("Logueados");
        }
        public ActionResult Logueados()
        {
            //ViewBag
            //ViewData
            
            ViewBag.Usuarios = LoginController.lista;
            return View();
        }
    }
}