using Servidor.Entidades;
using Servidor.Reglas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Servidor.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            return View(RNUsuario.Buscar());
        }
        // GET: Usuario/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Usuario/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Usuario/Create
        [HttpPost]
        public ActionResult Create(Usuario usuario)
        {
            try
            {
                // TODO: Add insert logic here
                RNUsuario.AgregarUsaurio(usuario);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Usuario/Edit/5
        public ActionResult Edit(int id)
        {
            return View(RNUsuario.Buscar(id));
        }

        // POST: Usuario/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Usuario usuario)
        {
            try
            {
                // TODO: Add update logic here

                RNUsuario.Editar(usuario);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Usuario/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Usuario/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Usuario usuario)
        {
            try
            {
                // TODO: Add delete logic here
                RNUsuario.Eliminar(id);

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View();
            }
        }
    }
}
