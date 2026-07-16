namespace SRPGood;

internal class Cart
{
    private Storage storage;

    public int ProductToBuyQuantity { get; private set; }

    public Cart(Storage storage, int productToBuyQuantity)
    {
        this.storage = storage;
        ProductToBuyQuantity = productToBuyQuantity;
    }

    public bool ValidateHasEnoughStock()
    {
        if (storage.ProductQuantity >= ProductToBuyQuantity)
        {
            return true;
        }
        Console.WriteLine("Not enough product left");
        return false;
    }
}