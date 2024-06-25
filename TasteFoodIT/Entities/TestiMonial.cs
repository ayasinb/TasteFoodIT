using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TasteFoodIT.Entities
{
    public class TestiMonial
    {
        public int TestimonialId { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public string NameSurname { get; set; }
        public string Title { get; set; }
    }
}