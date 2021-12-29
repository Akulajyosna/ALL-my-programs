using System;

namespace design
{
    class Program
    {
        static void Main()
        {
            int number;
            Console.Write("enter number:");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}{0}{0}", number);
            Console.WriteLine("{0} {0}", number);
            Console.WriteLine("{0} {0}", number);
            Console.WriteLine("{0} {0}", number);
            Console.WriteLine("{0}{0}{0}", number);
        }
    }
}
