namespace SRPGood;

internal class Program
{
    static void Main(string[] args)
    {
        var storage = new Storage(100, 20, 5, 2);
        var cart = new Cart(storage, 10);

        ICalculator calc = new PriceCalculator(storage);
        IFileLogger logger = new FileLogger();
        INotifier notifier = new Notificator();

        var service = new ShopService(storage, cart, calc, notifier, logger);
        service.ProcessPurchase();

        var cart2 = new Cart(storage, 90);

        var service2 = new ShopService(storage, cart2, calc, notifier, logger);
        service2.ProcessPurchase();

        var cart3 = new Cart(storage, 1);

        var service3 = new ShopService(storage, cart2, calc, notifier, logger);
        service3.ProcessPurchase();
    }
}