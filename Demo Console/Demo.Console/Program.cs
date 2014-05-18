using System;
using SimpleAntiGate;

namespace Demo.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                System.Console.WriteLine("*** Anticaptcha service AntiGate.com demo by http://geograph.us ***");
                System.Console.WriteLine("Usage: " + Environment.NewLine + "\tDemo.Console.exe AntiGateKey Filename|URL");
                System.Console.WriteLine("Example: " + Environment.NewLine + "\tDemo.Console.exe c54fa68f4d5s6df245s4d5c1a4s5d8f4 c:\\image.jpg");
                System.Console.WriteLine("\tDemo.Console.exe c54fa68f4d5s6df245s4d5c1a4s5d8f4 image.jpg>Result.txt");
                System.Console.WriteLine("\tDemo.Console.exe c54fa68f4d5s6df245s4d5c1a4s5d8f4 http://site.com/image.jpg");
                return;
            }

            try
            {
                AntiGate.AntiGateKey = args[0];
                var result = AntiGate.Recognize(args[1]);
                System.Console.WriteLine(result);
            }
            catch(Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }
    }
}
