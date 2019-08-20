using System;

namespace Sammak.ZigZagDemo
{
    public class ZigZagTester
    {
        public static void Run()
        {
            new ZigZagTester().TestOutput();
        }

        private void TestOutput()
        {
            const int rows = 3;
            //const string input = "HELLOWORLDANDME";
            const string input = "HELLOWORLDANDEVERYONE";
            var zigzag = new ZigZag { Rows = rows, InputText = input };
            var output = zigzag.GenerateOutputString();
            Console.WriteLine($"Output: {Environment.NewLine}{output}");
        }
    }
}
