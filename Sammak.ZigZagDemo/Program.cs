using Newtonsoft.Json;
using System;

namespace Sammak.ZigZagDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ZigZagTester.Run();
            }
            catch (Exception ex)
            {
                ShowException(ex);
            }
            finally
            {
                Console.WriteLine();
                Console.WriteLine("Press any Key to exit...");
                Console.ReadLine();
            }
        }

        private static void ShowException(Exception ex)
        {
            var js = JsonConvert.SerializeObject(ex, Formatting.Indented);
            Console.WriteLine(js);
        }
    }
}
