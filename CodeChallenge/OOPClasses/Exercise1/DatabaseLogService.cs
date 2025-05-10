namespace OOPClasses.Exercise1
{
    public class DatabaseLogService : ILogService
    {
        public void Log(string message)
        {
            Console.WriteLine("Logging by database: " + message);
        }
    }
}
