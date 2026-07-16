namespace SRPGood;

internal static class Validator
{
    public static bool ValidatePositiveProductCountOrder(int quantityToBuy)
    {
        if(quantityToBuy > 0)
        {
            return true;
        }

        Console.WriteLine("U can`t buy less then 1 product");
        return false;
    }
}