using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecom2
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Imageurl { get; set; }
    }
}