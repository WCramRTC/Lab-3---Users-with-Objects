using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3___Users_with_Objects
{
    public class ItemsInCart
    {
        int _amountOfItem;
        static int _totalCharge;
        //int _charge;

        public ItemsInCart(int amountOfItem)
        {
           _amountOfItem = amountOfItem;

        }
        public int AmountOfItem { get => _amountOfItem; protected set => _amountOfItem = value;}
        public static int TotalCharge { get => _totalCharge; set => _totalCharge = value;}
        //public int Charge { get => _charge; set => _charge = value; }

        public virtual void ChargeItem()
        {
            //_charge *= _amountOfItem;
            _totalCharge = 0;
        }
        //public override string ToString() 
        //{
        //    return $"Total: {_totalCharge.ToString("C")}";
        //}
    }//class
}//namespace
