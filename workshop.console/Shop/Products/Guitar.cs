using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workshop.console.Shop.Interfaces;

namespace workshop.console.Shop.Products
{
    public class Guitar : IProduct, IStringable, IDiscountable
    {
        public int Id {get;set;}
        public string Name {get;set;}
        public decimal Price { get; set; }
        public int NumberOfStrings { get; set; }
        public int Discount { get; set; } = 1;
    }
}
