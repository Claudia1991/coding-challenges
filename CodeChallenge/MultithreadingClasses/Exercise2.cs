namespace MultithreadingClasses
{
    public class Singleton
    {
        private static Lazy<Singleton> _instance = new Lazy<Singleton>(() => new Singleton());
        public static Singleton Instance => _instance.Value;

        private Singleton()
        {
            Console.WriteLine("Constructor");
        }

        public static void DoSomething()
        {
            Console.WriteLine("Method");
        }
    }

    public class Singleton2
    {
        private static object _lock = new object();
        private static readonly Singleton2 _instance;
        public static Singleton2 Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            return new Singleton2 ();
                        }
                    }
                }
                return _instance;
            }
        }

        private Singleton2()
        {
            Console.WriteLine("Constructor");
        }

        public static void DoSomething()
        {
            Console.WriteLine("Method");
        }
    }
}
