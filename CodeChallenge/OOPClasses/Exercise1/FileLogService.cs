namespace OOPClasses.Exercise1
{
    public class FileLogService : ILogService
    {
        public void Log(string message)
        {
            Console.WriteLine("Logging by file: " + message);
        }
    }
}
