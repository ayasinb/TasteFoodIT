using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TasteFoodIT.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal Price { get; set; }
        public string ImageURL { get; set; }
        public bool IsActive { get; set; }
        public int CategoryID { get; set; }

        public virtual Category Category { get; set; }


    }
}