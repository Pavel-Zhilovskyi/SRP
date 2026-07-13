namespace SRPGood;

internal class Notificator
{
    private string _message;

    public Notificator(string text)
    {
        _message = text;
    }

    public void SendEmailNotification()
    {
        Console.WriteLine($"Email: {_message}");
    }
}