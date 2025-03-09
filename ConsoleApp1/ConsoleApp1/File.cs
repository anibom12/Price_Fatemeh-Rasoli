namespace ConsoleApp1;

public class FileService:ILogger
{
    public string filePath;
    private StreamWriter writer;
    public FileService(string filePath)
    {
        this.filePath = filePath;
       

    }
    public void Logger(string message)
    {
        using (writer = new StreamWriter(filePath, true))
        {
            writer.WriteLine(message);
            writer.Flush();
        }


    }
    public void Alret(string alret)
    {
        Logger(alret);
    }

    
}
