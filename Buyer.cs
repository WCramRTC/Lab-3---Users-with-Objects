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
        List<Cart> _inCart;

        public Buyer(string firtName, string lastName)
        {
            FirtName = firtName;
            LastName = lastName;
            _inCart = new List <Cart>();
        }

        public string FirtName { get => _firtName; set => _firtName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        internal List<Cart> InCart { get => _inCart; }
        
        public void AddShoppingCart(Cart cart)
        {
             _inCart.Add(cart);
        }

        public override string ToString()
        {
            return $"{_firtName} {_lastName} - " +
                $"Amount of watch:{Watch.AmountOfItem}, Price:{Watch.PriceofWatch.ToString("C")}" +
                $"\nAmount of wallet:{Wallet.AmountOfItem}, Price:{Wallet.PriceOfWallet.ToString("C")}" +
                $"\nTotal Price:{Product.TotalCharge.ToString("C")}";
        }
    }
}
