using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PustokP322.Models
{
    public class Genre : BaseEntity
    {
        public string GenreName { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
