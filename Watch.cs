using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3___Users_with_Objects
{
    internal class Watch : Product
    {
        static int _priceofWatch;
        public Watch(int amountOfItem) : base(amountOfItem) 
        {
            _priceofWatch = 50;
            AmountOfItem = amountOfItem;
        }

        public static int PriceofWatch { get => _priceofWatch; }
        
        public override void ChargeItem()
        {
            _priceofWatch *= AmountOfItem;
            TotalCharge += _priceofWatch;
        }
        public override string ToString()
        {
            return this.GetType().Name + $":{50.ToString("C")} Amount: {AmountOfItem} Total Price: {_priceofWatch.ToString("C")}";
        }
    }
}
