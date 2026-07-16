using System;
using System.Collections.Generic;
using System.Text;

namespace SRPGood;

internal class ShopService
{
    private Storage _storage;
    private Cart _cart;

    private ICalculator _calculator;
    private INotifier _notifier;
    private IFileLogger _logger;

    public ShopService(Storage storage, Cart cart, ICalculator calculator, INotifier notifier, IFileLogger logger)
    {
        _storage = storage;
        _cart = cart;
        _calculator = calculator;
        _notifier = notifier;
        _logger = logger;
    }

    public void ProcessPurchase()
    {
        if (Validator.ValidatePositiveProductCountOrder(_cart.ProductToBuyQuantity))
        {
            if (_cart.ValidateHasEnoughStock()) 
            { 
                Console.WriteLine("There`re " + _storage.ProductQuantity + " of product left");
                Console.WriteLine("Price: " + _storage.Price);

                Console.WriteLine($"Products in cart: {_cart.ProductToBuyQuantity}");

                int total = _calculator.CountPriceWithSale(_calculator.CountPrice(_cart.ProductToBuyQuantity));
                Console.WriteLine("Total price of order: " + total);

                _storage.DecreaseProductQuantity(_cart.ProductToBuyQuantity);

                _notifier.SendEmailNotification($"U have successfully bought {_cart.ProductToBuyQuantity} c.u. of product" +
                    $" for {total}$");

                _logger.FileLog($"Count: {_cart.ProductToBuyQuantity}    Sale: {_storage.Sale}%     Total: {total}" +
                    $"      Left: {_storage.ProductQuantity}\n");
            }
        }
        
    }
}