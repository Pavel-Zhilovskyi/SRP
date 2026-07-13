namespace SRPGood;

internal class FileLogger
{
    private int productToBuy;
    private int sale;
    private int leftProduct;

    private string _filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log.txt");

    public FileLogger(int productToBuy, int sale, int leftProduct)
    {
        this.productToBuy = productToBuy;
        this.sale = sale;
        this.leftProduct = leftProduct;
    }

    public void FileLog(int totalPrice)
    {
        string text = $"Count: {productToBuy}    Sale: {sale}%     Total: {totalPrice}      Left: {leftProduct}\n";

        File.AppendAllText(_filePath, text);
    }
}