using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using PustokP322.ViewModel;
using PustokP322.DAL;
using PustokP322.Models;
using System.Collections.Generic;
using System.Linq;

namespace PustokP322.Controllers
{
    public class BookController : Controller
    {
        private readonly AppDbContext _context;

        public BookController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult AddBasket(int? id)
        {
            List<CookieVM> basketBooks;

            if (id == null) return NotFound();

            Book dbBook = _context.Books
                                .Include(g => g.Genre)
                                .Include(b => b.BookAuthors)
                                .ThenInclude(a => a.Author)
                                .Include(t => t.BookTags)
                                .ThenInclude(t => t.Tag)
                                .FirstOrDefault(b => b.Id == id);
           
            if(dbBook == null) return BadRequest("Book not find");

            string basket= Request.Cookies["basket"];

            if(basket != null)
            {
                basketBooks = JsonConvert.DeserializeObject<List<CookieVM>>(basket);


            }
            else { basketBooks = new List<CookieVM>(); }

            CookieVM basketBook = basketBooks.FirstOrDefault(b => b.Id == id);
            if (basketBook == null)
            {
                basketBooks.Add(new CookieVM
                {
                    Id = dbBook.Id,
                    Count = 1
                });
            }
            else
            {
                basketBook.Count++;
            }

            Response.Cookies.Append("basket", JsonConvert.SerializeObject(basketBooks));

            return Ok();
        }
    }
}
