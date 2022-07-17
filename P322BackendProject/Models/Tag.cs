using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PustokP322.Models
{
    public class Tag : BaseEntity
    {
        public string TagName { get; set; }

        public ICollection<BookTag> BookTags { get; set; }
    }
}
