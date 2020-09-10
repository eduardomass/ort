using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Servidor.Controllers
{
    public class JuegoController : Controller
    {
        // GET: Juego
        public ActionResult Jugar()
        {
            return View();
        }
    }
}