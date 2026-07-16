namespace SRPGood;

internal class FileLogger : IFileLogger
{
    private string _filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log.txt");

    public void FileLog(string text)
    {
        File.AppendAllText(_filePath, text);
    }
}