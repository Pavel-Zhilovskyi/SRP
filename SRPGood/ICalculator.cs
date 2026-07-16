namespace SRPGood;

internal interface ICalculator
{
    int CountPrice(int ProductToBuyQuantity);
    int CountPriceWithSale(int price);
}