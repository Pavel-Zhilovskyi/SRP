namespace SRPGood;

internal class PriceCalculator : ICalculator
{
    private Storage storage;

    public PriceCalculator(Storage storage)
    {
        this.storage = storage;
    }

    public int CountPrice(int ProductToBuyQuantity)
    {
        return storage.Price * ProductToBuyQuantity + storage.Tax;
    }

    public int CountPriceWithSale(int price)
    {
        return price - (price * storage.Sale) / 100;
    }
}