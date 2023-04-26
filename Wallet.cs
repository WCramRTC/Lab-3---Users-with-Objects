using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3___Users_with_Objects
{
    internal class Wallet : ItemsInCart
    {
        int _priceOfWallet;
        public Wallet(int amountOfItem) : base(amountOfItem)
        {
            _priceOfWallet = 70;
        }

        public int PriceOfWallet { get => _priceOfWallet;}
        public override void Charge()
        {
            _priceOfWallet *= AmountOfItem;
            TotalCharge += _priceOfWallet *= AmountOfItem;

        }
        //this.GetType().Name + $" {_priceOfWallet.ToString("C")}, Amount: {AmountOfItem}";
         public override string ToString() 
        {
            return this.GetType().Name + $":{70.ToString("C")} Amount: {AmountOfItem} Total Price: {_priceOfWallet.ToString("C")},";
        }
    }
}
