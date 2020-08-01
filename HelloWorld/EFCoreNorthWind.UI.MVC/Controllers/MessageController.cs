using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCoreNorthWind.UI.MVC.ModelosFalsos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EFCoreNorthWind.UI.MVC.Controllers
{
    public class MessageController : Controller
    {
        // GET: MesssageController
        public ActionResult Index()
        {
            var elResultado = ListarTodosLosMensajes();
            return View(elResultado);
        }

        private IList<ModelosFalsos.Mensaje> ListarTodosLosMensajes()
        {
            var elRepositorio = new ElementosFalsos.Repositorio.Mensajes();
            var elResultado = elRepositorio.ObtenerTodos();
            return elResultado;
        }

        // GET: MesssageController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MesssageController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MesssageController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Mensaje losDatos)
        {
            if (!ModelState.IsValid)
                return View();
            else
            {
                try
                {
                    GrabarMensaje(losDatos);
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View();
                }
            }
        }

        private void GrabarMensaje(Mensaje losDatos)
        {
            var elRepositorio = new ElementosFalsos.Repositorio.Mensajes();
            elRepositorio.GrabarMensaje(losDatos);
        }

        // GET: MesssageController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MesssageController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MesssageController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MesssageController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
