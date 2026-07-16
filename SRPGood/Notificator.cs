namespace SRPGood;

internal class Notificator : INotifier
{
    public void SendEmailNotification(string message)
    {
        Console.WriteLine($"Email: {message}");
    }
}