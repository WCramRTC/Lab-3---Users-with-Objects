using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3___Users_with_Objects
{
    internal class ItemsInCart
    {
        int _amountOfItem;
        public int _totalCharge;

        public ItemsInCart(int amountOfItem)
        {
            _amountOfItem = amountOfItem;

        }

        public int AmountOfItem { get => _amountOfItem; protected set => _amountOfItem = value; }
        public int TotalCharge { get => _totalCharge; set => _totalCharge = value; }
        

        public virtual void Charge()
        { 
           
        
        }
        public override string ToString() 
        {
            return $"Total: {_totalCharge.ToString("C")}";
        }
    }//class
}//namespace
