using PustokP322.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PustokP322.ViewModel
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }

        public List<Book> Books { get; set; }

        public List<Book> FeaturedBooks { get; set; }

        public List<Book> NewBooks { get; set; }

        public List<Book> DiscountBooks { get; set; }


    }
}
