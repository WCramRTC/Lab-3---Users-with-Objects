using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3___Users_with_Objects
{
    internal class Buyer
    {
        string _firtName;
        string _lastName;
        Cart _inCart;

        // Remove the LIST of Cart, and only have a Cart.

        public Buyer(string firtName, string lastName)
        {
            FirtName = firtName;
            LastName = lastName;
            _inCart = new Cart();
        }

        public string FirtName { get => _firtName; set => _firtName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        internal Cart InCart { get => _inCart; }
        
        public void AddItemToCart(Product product, int quantity )
        {
            ItemInCart newItem = new ItemInCart(product, quantity);
            _inCart.AddItemToCart(newItem);
        }

        public void DisplayCartInformation()
        {
            Console.WriteLine(ToString());
            _inCart.DisplayItemsInCart();
        }


        public override string ToString()
        {
            return $"{_firtName} {_lastName}";
        }
    }
}
