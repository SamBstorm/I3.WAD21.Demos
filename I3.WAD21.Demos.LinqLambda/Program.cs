using System;

namespace I3.WAD21.Demos.LinqLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //OperationMath operations = Mathematique.Addition;
            OperationMath operations = (x, y) => (int)(x + y);
            Func<double, double, int> operations_generic = (x, y) => (int)(x + y);
            operations = (x, y) => (int)(x * y);

            ActionConsole action = message => Console.WriteLine(message);
            Action<string> action_generic = message => Console.WriteLine(message);
            
            Action<int, string> exemple = (number, text) =>
            {
                for (int i = 0; i < number; i++)
                {
                    Console.WriteLine(text);
                }
            };
            exemple(8, "Toto");
            action("toto");
            FilterDelegate filter = (x) => x % 2 == 0;
            int[] ints = { 1, 2, 3, 4, 5, 6 };
            foreach (int number in ints)
            {
                if (filter(number)) Console.WriteLine(number);
            }

            Console.WriteLine( operations(5, 3));
        }
    }

    delegate int OperationMath(double nb1, double nb2);
    

    delegate void ActionConsole(string text);
    delegate void MultiplierTexte(int quantité,string message);
    delegate bool FilterDelegate(int number);

    struct Mathematique
    {
        public static int Addition(int left, int right)
        {
            return left + right;
        }
    }
}
