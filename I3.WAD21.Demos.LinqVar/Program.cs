using System;

namespace I3.WAD21.Demos.LinqVar
{
    class Program
    {
        static void Main(string[] args)
        {
            var message = "Hello world";
            var number = 5.1F;
            var variable;

            Console.WriteLine(message.GetType());
            Console.WriteLine(number.GetType());
        }
    }
}
