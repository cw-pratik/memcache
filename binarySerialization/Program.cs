using System;
using System.Threading;

namespace Service
{
    class Program
    {
        private static IMemcachedClient _client;
        public static void Main(string[] args)
        {
            Startup startUp = new Startup ();
            ServiceProvider serviceProvider = startUp.InitialiseServices();

            _client = serviceProvider.GetService<IMemcachedClient>();
            ThreadPool.SetMaxThreads(100, 100);
            ThreadPool.SetMinThreads(100, 100);

            for (int i = 0; i < 2000; i++)
            {
                //ThreadPool.QueueUserWorkItem(new WaitCallback(TaskCallBack), i);
            }

            //channel.ShutdownAsync().Wait();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }


        public async Task<bool> Create()
        {
            var cacheKey = "blogposts-recent";
            var cacheSeconds = 600;

            var posts = await _client.GetValueOrCreateAsync(
                cacheKey,
                cacheSeconds,
                new ItemData());

            return true;
        }

    }

}