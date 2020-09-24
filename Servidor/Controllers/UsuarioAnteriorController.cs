using Servidor.Entidades;
using Servidor.Models;
using Servidor.Reglas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Servidor.Controllers
{
    public class UsuarioAnteriorController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(UsuarioLogin usuario)
        {
            var usuarioLogueado = RNUsuario.ObtenerUsuarioActivo(usuario.Nombre, usuario.Password);
            if (usuarioLogueado == null)
            {
                ViewBag.Error = "Usaurio Incorrecto";
                return View();
            }
            else
            {
                Session["Usuario"] = usuarioLogueado;
                return RedirectToAction("Logueado");
            }
            
        }
        public ActionResult Logueado()
        {
            var usuarioLogueado = (Entidades.Usuario)Session["Usuario"];
            return View(usuarioLogueado);
        }
        public ActionResult Lista()
        {
            
            return View(RNUsuario.Buscar());
        }

        public ActionResult Create()
        {
            return View(new Entidades.Usuario());
        }

        [HttpPost]
        public ActionResult Create(Usuario usuario)
        {
            RNUsuario.AgregarUsaurio(usuario);
            return View(usuario);
        }
    }
}