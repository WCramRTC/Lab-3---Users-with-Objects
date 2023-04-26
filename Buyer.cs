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
        List<ItemsInCart> _inCart;

        public Buyer(string firtName, string lastName)
        {
            FirtName = firtName;
            LastName = lastName;
            _inCart = new List <ItemsInCart>();
        }

        public string FirtName { get => _firtName; set => _firtName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        internal List<ItemsInCart> InCart { get => _inCart; }

        public void addItem(ItemsInCart itemInCart)
        {
        _inCart.Add(itemInCart);
        }

        public override string ToString()
        {
            return $"{_firtName} {_lastName}";
        }
    }
}
