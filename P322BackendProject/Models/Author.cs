using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PustokP322.Models
{
    public class Author : BaseEntity
    {
        public string Name { get; set; }


        public ICollection<BookAuthor> BookAuthors { get; set; }
    }
}
