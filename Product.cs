using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3___Users_with_Objects
{
    internal class Product
    {
        static int _amountOfItem;
        static int _totalCharge;

        public Product(int amountOfItem)
        {
            _amountOfItem = amountOfItem;

        }
        public static int AmountOfItem { get => _amountOfItem; protected set => _amountOfItem = value; }
        public static int TotalCharge { get => _totalCharge; set => _totalCharge = value; }


        public virtual void ChargeItem()
        {
            _totalCharge = 0;
        }
    }//class
}//namespace
