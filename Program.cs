namespace Lab_3___Users_with_Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Buyer> user = new List<Buyer>();
           
            Buyer buyer1 = new Buyer("M", "H");
           
            Watch watch = new Watch(3);
            Wallet wallet = new Wallet(4);

            buyer1.addItem(watch);//add items to list
            buyer1.addItem(wallet);

            
            watch.Charge(); //chrge
            wallet.Charge();

            Console.WriteLine(watch);
            Console.WriteLine(wallet);
            Console.WriteLine(buyer1);
           



        }
    }
}