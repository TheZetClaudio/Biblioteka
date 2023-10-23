using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BibList.Models;

namespace BibList.Controllers
{
    public class BiblistController : Controller
    {
        // GET: BiblistController
        public ActionResult Index()
        {
            return View();
        }


        private static IList<Biblist> Books = new List<Biblist>
        {
            new Biblist(){Id = 1, Title = "Pan Tadeusz", Author = "Adam Mickiewicz", PublishingHouse = "MendaJednaStudio", ReleaseDate = "28/06/1834", InStock = 10 },
		    new Biblist(){Id = 2, Title = "Dziady cz.II", Author = "Adam Mickiewicz", PublishingHouse = "MendaJednaStudio", ReleaseDate = "--/--/1826", InStock = 1 }

		};
        public ActionResult Booklist()
        {
            return View();
        }
        // GET: BiblistController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BiblistController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BiblistController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: BiblistController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BiblistController/Edit/5
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

        // GET: BiblistController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BiblistController/Delete/5
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
