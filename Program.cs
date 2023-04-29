namespace Lab_3___Users_with_Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Buyer> user = new List<Buyer>();
           
            Buyer buyer1 = new Buyer("Monika", "H");
          //First create instance for item
            Watch watch = new Watch(1);
            Wallet wallet = new Wallet(3);


          //Calculate, charge them
            watch.ChargeItem(); 
            wallet.ChargeItem();

          //Create cart instance
            Cart cart = new Cart();

          //Add Item to cart
            cart.AddItemtoCart(watch);
            cart.AddItemtoCart(wallet);

          //add shoopingcart to the buyer
            buyer1.AddShoppingCart(cart);

            user.Add(buyer1);

            Console.WriteLine(user[0]);
            //Console.WriteLine(user1);





        }
    }
}