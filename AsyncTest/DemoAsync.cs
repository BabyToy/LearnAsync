using System;
using System.Threading.Tasks;

namespace AsyncTest
{
    public class DemoAsync
    {
        public async Task RunTest()
        {
            Console.WriteLine("Calling async");
            DoStringAsync().GetAwaiter();
            Console.WriteLine("Resuming from async");
            await Task.Delay(10000);
        }

        async Task<string> ReadStringAsync()
        {
            Console.WriteLine("Starting async");
            await Task.Delay(1000);
            Console.WriteLine("Ending async");
            return "test string";
        }

        async Task DoStringAsync()
        {
            Console.WriteLine("Starting async");
            await Task.Delay(1000);
            Console.WriteLine("Ending async");
        }
    }
}
