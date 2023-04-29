namespace Lab_3___Users_with_Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Buyer> user = new List<Buyer>();
           
            Buyer buyer1 = new Buyer("Monika", "H");
          //First create instance for item

            // Create new items with a price
            Watch watch = new Watch(70);
            Wallet wallet = new Wallet(30);
            //Console.WriteLine(watch);
            //Console.WriteLine(wallet);

            buyer1.AddItemToCart(watch, 5);
            buyer1.AddItemToCart(wallet, 3);
            buyer1.DisplayCartInformation();


            //buyer1.InCart.DisplayItemsInCart();

            //ItemInCart itemInCart = new ItemInCart(watch, 5);
            //Console.WriteLine(itemInCart);
            

            //ItemInCart watches = new ItemInCart(new Watch(70), 5);

            ////Create cart instance
            //  Cart cart = new Cart();


            //add shoopingcart to the buyer
            //buyer1.AddShoppingCart(cart);

            //user.Add(buyer1);

            //Console.WriteLine(user[0]);
            //Console.WriteLine(user1);





        }
    }
}