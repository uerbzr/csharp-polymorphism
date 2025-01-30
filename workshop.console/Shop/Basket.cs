using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workshop.console.Shop.Interfaces;

namespace workshop.console.Shop
{
    public class Basket
    {
        private List<IProduct> _products = new List<IProduct>();

        public void AddProduct(IProduct product)
        {
            _products.Add(product);
        }

        public decimal Total { get { return _products.Sum(product => product.Price); } }

        public List<IProduct> Products { get { return _products; } }

    }
}