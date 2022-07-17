using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PustokP322.DAL;
using PustokP322.Models;
using PustokP322.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PustokP322.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM
            {
                Sliders =  _context.Sliders.ToList(),
                Books = _context.Books
                            .Include(g => g.Genre)
                            .Include(b => b.BookAuthors)
                            .ThenInclude(a => a.Author)
                            .Include(t => t.BookTags)
                            .ThenInclude(t => t.Tag)
                            .Take(7)
                            .ToList(),

                FeaturedBooks = _context.Books
                                .Include(g => g.Genre)
                                .Include(b => b.BookAuthors)
                                .ThenInclude(a => a.Author)
                                .Include(t => t.BookTags)
                                .ThenInclude(t => t.Tag)
                                .Where(b => b.IsFeatured == true)
                                .ToList(),

                NewBooks = _context.Books
                                .Include(g => g.Genre)
                                .Include(b => b.BookAuthors)
                                .ThenInclude(a => a.Author)
                                .Include(t => t.BookTags)
                                .ThenInclude(t => t.Tag)
                                .Where(b => b.IsNew == true)
                                .ToList(),

                DiscountBooks = _context.Books
                                .Include(g => g.Genre)
                                .Include(b => b.BookAuthors)
                                .ThenInclude(a => a.Author)
                                .Include(t => t.BookTags)
                                .ThenInclude(t => t.Tag)
                                .Where(x => x.DiscountPercent > 0)
                                .ToList()
            };

            return View(homeVM);
        }


        public IActionResult GetBook(int id)
        {
            Book book = _context.Books
                                .Include(g => g.Genre)
                                .Include(b => b.BookAuthors)
                                .ThenInclude(a => a.Author)
                                .Include(t => t.BookTags)
                                .ThenInclude(t => t.Tag)
                                .FirstOrDefault(b => b.Id == id);

            return PartialView("_ModalDetailPartial" , book);
        }
    }
}
