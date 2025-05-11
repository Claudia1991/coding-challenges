namespace MultithreadingClasses
{
    public class Exercise3
    {
        public async Task<string> BackgroundWorker(Func<Task> longTask)
        {
			try
			{
                await Task.Run(longTask);
                return "Works!";
			}
			catch (Exception)
			{
                return "Something wrong happen";
			}
        }
    }

    public class PrincipalWorker
    {
        public async Task RunExample()
        {
            Exercise3 exercise3 = new Exercise3();

            Func<Task> longTask = async () =>
            {
                Console.WriteLine("Start background");
                await Task.Delay(3000);
                Console.WriteLine("Finish background");
            };

            Console.WriteLine("Main thread finished");
            
            var result = await exercise3.BackgroundWorker(longTask);
            Console.WriteLine("Result background worker: " + result);
        }
    }
}
