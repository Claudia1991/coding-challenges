namespace OOPClasses.Exercise1
{
    public static class LogServiceFactory
    { 

        public static ILogService CreateLogger(LogEnum typeLogger)
        {
            switch (typeLogger)
            {
                case LogEnum.DATABASE:
                    return new DatabaseLogService();
                case LogEnum.FILE:
                    return new FileLogService();
                case LogEnum.CONSOLE:
                    return new ConsoleLogService();
                default:
                    return new DatabaseLogService();
            }
        }
    }
}
