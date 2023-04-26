using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3___Users_with_Objects
{
    internal class Watch : ItemsInCart
    {
        int _priceofWatch;
        public Watch(int amountOfItem) : base(amountOfItem) 
        {
            _priceofWatch = 50;
        }

        public int PriceofWatch { get => _priceofWatch;}
        public override void Charge()
        {
            _priceofWatch *= AmountOfItem;
            TotalCharge += _priceofWatch *= AmountOfItem;
        }
        public override string ToString()
        {
            return this.GetType().Name + $":{50.ToString("C")} Amount: {AmountOfItem} Total Price: {_priceofWatch.ToString("C")}";
        }
    }
}
