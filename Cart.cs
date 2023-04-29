using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3___Users_with_Objects
{
    internal class Cart
    {
        List <Product> _products;

        public Cart()
        {
            _products = new List <Product>();
        }

        internal List<Product> Products { get => _products; set => _products = value; }
        public void AddItemtoCart(Product product)
        {
            _products.Add(product);
        }
        
    }
}
