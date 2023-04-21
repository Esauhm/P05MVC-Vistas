using Microsoft.AspNetCore.Mvc;
using MVC_Practica01.Models;

namespace MVC_Practica01.Controllers
{
    public class EquiposController : Controller
    {
        private readonly EquiposDBContext _equiposDbContext;
        public EquiposController(EquiposDBContext equiposDbContext)
        {
            _equiposDbContext = equiposDbContext;
        }

        // GET: equiposCRUDController
        public ActionResult Index()
        {
            var equipoList = (from e in _equiposDbContext.equipos
                              select e);
            ViewData["equipoList"] = equipoList.ToList();

            return View();
        }

        // GET: equiposCRUDController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: equiposCRUDController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: equiposCRUDController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind("nombre", "descripcion", "modelo", "anio_compra", "costo", "vida_util", "tipo_equipo_id", "marca_id", "estado_equipo_id")] equipos equipoNuevo)
        {
            try
            {
                _equiposDbContext.Add(equipoNuevo);
                await _equiposDbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: equiposCRUDController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: equiposCRUDController/Edit/5
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

        // GET: equiposCRUDController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: equiposCRUDController/Delete/5
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
