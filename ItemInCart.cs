using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3___Users_with_Objects
{
    internal class ItemInCart
    {

        Product _product;
        int _qty;

        public ItemInCart(Product product, int qty)
        {
            _product = product;
            _qty = qty;
        }

        public double CalculateTotal()
        {
            return _product.Price * _qty;
        }

        public override string ToString()
        {
            return _product.ToString() + $" - Qty : {_qty} : {CalculateTotal().ToString("c")}";
        }
    }
}
