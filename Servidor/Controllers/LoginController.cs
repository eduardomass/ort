using Servidor.Entidades;
using Servidor.Models;
using Servidor.Reglas;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Servidor.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(UsuarioLogin usuario)
        {
            var usuarioActivo = RNUsuario.ObtenerUsuarioActivo(usuario.Nombre, usuario.Password);
            if (usuarioActivo == null)
            {
                //No se loguea
                ViewBag.Error = "Usuario incorrecto o inactivo.";
            }
            else
            {
                Session["Usuario"] = usuarioActivo;
                return View();
            }
            return View();
        }
        public ActionResult UploadImagen(HttpPostedFileBase file)
        {
            if (file != null && file.ContentLength > 0)
                try
                {
                    string directorio = Path.Combine(Server.MapPath("~/Imagenes/" +
                        ((Usuario)Session["Usuario"]).Id + "/"));
                    DirectoryInfo di = new DirectoryInfo(directorio);
                    if (!di.Exists)
                        di.Create();

                    string path = Path.Combine(Server.MapPath("~/Imagenes/" + 
                        ((Usuario)Session["Usuario"]).Id + "/" ),
                                               Path.GetFileName("Caratula.jpg"));

                    file.SaveAs(path);
                    ViewBag.Message = "File uploaded successfully";
                }
                catch (Exception ex)
                {
                    ViewBag.Message = "ERROR:" + ex.Message.ToString();
                }
            else
            {
                ViewBag.Message = "You have not specified a file.";
            }
            return View("Index");
        }
    }
}