using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PustokP322.Models
{
    public class Book : BaseEntity
    {
        public string Name { get; set; }

        public string Code { get; set; }

        public bool IsFeatured { get; set; }

        public bool IsNew { get; set; }

        public double CostPrice { get; set; }

        public double SalePrice { get; set; }

        public double DiscountPercent { get; set; }

        public string Description { get; set; }

        public bool IsAvailability { get; set; }

        public string ImageUrl { get; set; }

        public int GenreId { get; set; }

        public Genre Genre { get; set; }

        public ICollection<BookAuthor> BookAuthors { get; set; }

        public ICollection<BookTag> BookTags { get; set; }

        
    }
}

