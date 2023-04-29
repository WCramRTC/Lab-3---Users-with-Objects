using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3___Users_with_Objects
{
    internal class Product
    {

        double _price;

        public Product(double price)
        {
            _price = price;
        }

        public double Price { get => _price; set => _price = value; }

        public override string ToString()
        {
            return $"{this.GetType().Name} - Price: {this.Price.ToString("c")}";
        }
    }//class
}//namespace
