using SRPBad;

namespace SRP;

internal class Program
{
    static void Main(string[] args)
    {
        var marketPlace = new MarketPlace(100, 12, 5, 2);

        Console.WriteLine("Product left: " + marketPlace.GetProductQuantity());
        Console.WriteLine("Price: " + marketPlace.GetPrice());
        Console.WriteLine("Sale: " + marketPlace.GetSalePrice() + "%\n");

        if (marketPlace.ValidateOffer(-5))
        {
            int totalPrice = marketPlace.CountPriceWithSale(marketPlace.CountOfferPrice());

            Console.WriteLine($"Total: {totalPrice}\n");

            marketPlace.Buy();

            marketPlace.EmailMessaging(totalPrice);

            marketPlace.FileLog(totalPrice);

            Console.WriteLine("Product left: " + marketPlace.GetProductQuantity() + "\n");
        }
        else
        {
            Console.WriteLine("Not enough product left in the storage");
        }
    }
}