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

    public bool ValidateOrder()
    {
        if (storage.ProductQuantity >= ProductToBuyQuantity)
        {
            return true;
        }
        return false;
    }



    public void Buy()
    {
        storage.DecreaseProductQuantity(ProductToBuyQuantity);
    }
}