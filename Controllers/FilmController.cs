using film_zad.Migrations;
using film_zad.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace film_zad.Controllers
{
    public class FilmController : Controller
    {

        private readonly FilmDbContext _context;
        public FilmController(FilmDbContext context)
        {
            _context = context;
        }
        // GET: FilmController
        public ActionResult Index()
        {
            var filmyZKategoria = _context.Films.Include (f => f.Kategoria).ToList();
            return View(filmyZKategoria);
        }
        
        // GET: FilmController/Details/5
        public ActionResult Details(int id)
        {
            return View(_context.Films.Find(id));
        }

        // GET: FilmController/Create
        public ActionResult Create()
        {
            var kategoria = _context.Kategoria.ToList();
            ViewBag.KategoriaId = new SelectList(kategoria, "Id", "Name", "Price");
            return View();
        }

        // POST: FilmController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("Id,Name,Description,Price,KategoriaId")]Film film)
        {
            try
            {
                _context.Films.Add(film);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                var kategoria = _context.Kategoria.ToList();
                ViewBag.KategoriaId = new SelectList(kategoria, "Id", "Name");
                return View(film);
            }

        }

        // GET: FilmController/Edit/5
        public ActionResult Edit(int id)
        {
            Film film = _context.Films.Find(id);
            return View(film);
        }

        // POST: FilmController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Film film)
        {
            var film1 = _context.Films.Find(id);
            film1.Name = film.Name;
            film1.Description = film.Description;
            film1.Price = film.Price;
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        // GET: FilmController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_context.Films.Find(id));
        }

        // POST: FilmController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Film film)
        {
            var film1 = _context.Films.FirstOrDefault(x => x.Id == id);

            _context.Films.Remove(film1);

            _context.SaveChanges();

            return RedirectToAction(nameof(Index));

        }
    }
}
