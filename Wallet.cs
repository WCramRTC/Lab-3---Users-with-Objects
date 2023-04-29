using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3___Users_with_Objects
{
    internal class Wallet : Product
    {
        static int _priceOfWallet = 70;
        public Wallet(int amountOfItem) : base(amountOfItem)
        {
            _priceOfWallet = 70;
            AmountOfItem = amountOfItem;

        }
        public static int PriceOfWallet { get => _priceOfWallet;}
        public override void ChargeItem()
        {
            _priceOfWallet *= AmountOfItem;
            TotalCharge += _priceOfWallet; 
        }
         public override string ToString() 
        {
            return this.GetType().Name + $":{70.ToString("C")} Amount: {AmountOfItem} Total Price: {_priceOfWallet.ToString("C")}";
        }
    }//class
}//namesapce
