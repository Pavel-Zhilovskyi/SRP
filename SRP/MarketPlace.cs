namespace SRPBad;

internal class MarketPlace
{
    private int _price;

    private int _productQuantity;
    private int _productToBuyQuantity;

    private int _salePrice;

    private int _tax;

    private string _filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log.txt");

    public MarketPlace(int price, int productQuantity, int salePrice, int tax)
    {
        _price = price;
        _productQuantity = productQuantity;
        _salePrice = salePrice;
        _tax = tax;
    }

    public int GetPrice() { return _price; }
    public int GetProductQuantity() { return _productQuantity; }
    public int GetSalePrice() { return _salePrice; }

    public bool ValidateOffer(int productToBuyQuantity)
    {
        _productToBuyQuantity = productToBuyQuantity;

        if(_productToBuyQuantity <= _productQuantity)
        {
            return true;
        }
        return false;
    }

    public int CountOfferPrice()
    {
        return _price * _productToBuyQuantity + _tax;
    }

    public int CountPriceWithSale(int priceAfterTax)
    {
        return priceAfterTax - (priceAfterTax * _salePrice) / 100;
    }

    public void Buy()
    {
        _productQuantity -= _productToBuyQuantity;
    }

    public void EmailMessaging(int totalPrice)
    {
        Console.WriteLine($"Email: U have successfully bought {_productToBuyQuantity} of product, for {totalPrice}$");
    }

    public void FileLog(int totalPrice)
    {
        string text = $"Count: {_productToBuyQuantity}    Sale: {_salePrice}%     Total: {totalPrice}      Left: {_productQuantity}\n";

        File.AppendAllText(_filePath, text);
    }
}


//if we start selling our products not one by one but a few at a time,
//we will have to change supply method(constructor) too
//each time adding new functionality I need to open one big file 
//where things lie mixed together, unconnected by any logic