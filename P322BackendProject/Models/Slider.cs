using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PustokP322.Models
{
    public class Slider : BaseEntity
    {
        public string ImageUrl  { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }
    }
}
