using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3___Users_with_Objects
{
    internal class Cart
    {
        List<ItemInCart> _items;

        public Cart()
        {
            _items = new List<ItemInCart>();
        }

        internal List<ItemInCart> Items { get => _items; }

        // Item represents both the product AND the qty
        public void AddItemToCart(ItemInCart item)
        {
            _items.Add(item);
        }

        // I want to be able to calculate the total cost of everything in the cart.

        public void DisplayItemsInCart()
        {
            foreach (ItemInCart item in _items)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine($"Total of All Items: {CalculateTotalOfItemsInTheCart().ToString("c")}");
        }

        public double CalculateTotalOfItemsInTheCart()
        {
            double sum = 0;

            foreach (ItemInCart item in _items)
            {
                sum += item.CalculateTotal();
            }

            return sum;

        }
    }
}
