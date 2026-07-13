namespace SRPGood;

internal class Storage
{
    public int ProductQuantity { get; private set; }
    public int Price { get; private set; }
    public int Sale { get; private set; }
    public int Tax { get; private set; }

    public Storage(int productQuantity, int price, int sale, int tax)
    {
        ProductQuantity = productQuantity;
        Price = price;
        Sale = sale;
        Tax = tax;
    }

    public void DecreaseProductQuantity(int boughtQuantity)
    {
        if(boughtQuantity <= ProductQuantity)
        {
            ProductQuantity -= boughtQuantity;
        }
    }
}