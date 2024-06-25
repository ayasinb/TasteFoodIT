using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TasteFoodIT.Entities
{
    public class Chef
    {
        public int ChefId { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public string Title { get; set; }
        public string NameSurname { get; set; }
    }
}