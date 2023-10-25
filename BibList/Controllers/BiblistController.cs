using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BibList.Models;

namespace BibList.Controllers
{
    public class BiblistController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        private static IList<Biblist> Books = new List<Biblist>
        {
            new Biblist(){Id = 1, Title = "Pan Tadeusz", Author = "Adam Mickiewicz", PublishingHouse = "MendaJednaStudio", ReleaseDate = "28/06/1834", InStock = 10 },
		    new Biblist(){Id = 2, Title = "Dziady cz.I1", Author = "Adam Mickiewicz", PublishingHouse = "MendaJednaStudio", ReleaseDate = "--/--/1826", InStock = 6 },
            new Biblist(){Id = 3, Title = "Dziady cz.II", Author = "Adam Mickiewicz", PublishingHouse = "MendaJednaStudio", ReleaseDate = "--/--/1826", InStock = 1 },
			new Biblist(){Id = 4, Title = "Dziady cz.III", Author = "Adam Mickiewicz", PublishingHouse = "MendaJednaStudio", ReleaseDate = "--/--/1826", InStock = 2 },
			new Biblist(){Id = 5, Title = "Dziady cz.IV", Author = "Adam Mickiewicz", PublishingHouse = "MendaJednaStudio", ReleaseDate = "--/--/1826", InStock = 2 },
			new Biblist(){Id = 6, Title = "średnia Hawajska dla każdego", Author = "Admirał Jahaś", PublishingHouse = "ŁęcinaStudioRemontowoBudowlaonKsiążkarska", ReleaseDate = "17/13/3250", InStock = 5032112 },

		};
        public ActionResult Booklist()
        {
            return View(Books);
        }

        public ActionResult BooklistDetails(int id)
        {
            return View(Books.FirstOrDefault(x=>x.Id == id));
        }

        // GET: BiblistController/Create
        public ActionResult BooklistCreate()
        {
            return View();
        }

        // POST: BiblistController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult BooklistCreate(Biblist book)
        {
            book.Id = Books.Count + 1;
            Books.Add(book);
            return RedirectToAction();
        }

        // GET: BiblistController/Edit/5
        public ActionResult BooklistEdit(int id)
        {
            return View(Books.FirstOrDefault(x=>x.Id==id));
        }

        // POST: BiblistController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult BooklistEdit(int id, Biblist book)
        {
            Biblist book1 = Books.FirstOrDefault(x => x.Id == id);
            book1.Title = book.Title;
            book1.Author = book.Author;
            book1.PublishingHouse = book.PublishingHouse;
            book1.ReleaseDate = book.ReleaseDate;
            book1.InStock = book.InStock;
            return RedirectToAction();
        }

        // GET: BiblistController/Delete/5
        public ActionResult BooklistDelete(int id)
        {
            return View(Books.FirstOrDefault(x => x.Id == id));
        }

        // POST: BiblistController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult BooklistDelete(int id, IFormCollection collection)
        {
            Books.Remove(Books.FirstOrDefault(x=>x.Id==id));
            return RedirectToAction();
        }






        private static IList<Userlist> Users = new List<Userlist>()
        {
            new Userlist() {Id= 1, PESEL = "11111111111", Name = "Grzegorz", Surename = "Brzęczyszczykiewicz", BorrowedId = "6"}
        };
        public ActionResult Userlist()
        {
            return View(Users);
        }

        public ActionResult UserlistCreate()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UserlistCreate(Userlist user)
        {
            user.Id = Users.Count + 1;
            Users.Add(user);
            return RedirectToAction();
        }

        public ActionResult UserlistEdit(int id)
        {
            return View(Users.FirstOrDefault(x=>x.Id==id));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UserlistEdit(int id, Userlist user)
        {
            Userlist user1 = Users.FirstOrDefault(x => x.Id == id);
            user1.PESEL= user.PESEL;
            user1.Name= user.Name;
            user1.Surename= user.Surename;
            user1.BorrowedId= user.BorrowedId;
          
            return RedirectToAction();
        }
        public ActionResult UserlisDelete(int id)
        {
            return View(Users.FirstOrDefault(x => x.Id == id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UserlisDelete(int id, IFormCollection collection)
        {
            Users.Remove(Users.FirstOrDefault(x=>x.Id==id));
            return RedirectToAction();
        }
    }
}
