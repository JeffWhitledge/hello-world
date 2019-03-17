using System;
using System.Resources;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var res = new ResourceManager(typeof(Properties.Resources));
            Console.WriteLine(res.GetString("WorldGreeting"));
            WaitForUser(res);
        }

        private static void WaitForUser(ResourceManager res)
        {
            Console.WriteLine(res.GetString("PressEnterToContinue"));
            Console.ReadLine();
        }
    }
}
