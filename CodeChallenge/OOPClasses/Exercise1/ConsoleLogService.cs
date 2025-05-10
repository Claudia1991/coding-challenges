namespace OOPClasses.Exercise1
{
    public class ConsoleLogService : ILogService
    {
        public void Log(string message)
        {
            Console.WriteLine("Logging by console: " + message);
        }
    }
}
