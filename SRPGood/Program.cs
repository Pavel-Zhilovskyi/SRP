namespace SRPGood;

internal class Program
{
    static void Main(string[] args)
    {
        var storage = new Storage(100, 20, 5, 2);

        var cart = new Cart(storage, 10);

        var calc = new PriceCalculator(storage);

        Console.WriteLine("There`re " + storage.ProductQuantity + " of product left");
        Console.WriteLine("Price: " + storage.Price);

        if (Validator.ValidateOrder(cart.ProductToBuyQuantity))
        {
            if (cart.ValidateOrder())
            {
                int total = calc.CountPriceWithSale(calc.CountPrice(cart.ProductToBuyQuantity));
                Console.WriteLine("Total price of order: " + total);

                cart.Buy();

                var notificator = new Notificator($"U have successfully bought {cart.ProductToBuyQuantity} c.u. of product" +
                    $" for {total}$");
                notificator.SendEmailNotification();

                var logger = new FileLogger(cart.ProductToBuyQuantity, storage.Sale, storage.ProductQuantity);
                logger.FileLog(total);
            }
        }
    }
}