using System;

namespace add
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int table;
            Console.Write("enter fisrt num:");
            a = int.Parse(Console.ReadLine());
            table = a * 1;
            Console.WriteLine("{0}*{1}={2}", a, 1, table);
            table = a * 2;
            Console.WriteLine("{0}*{1}={2}", a, 2, table);
            table = a * 3;
            Console.WriteLine("{0}*{1}={2}", a, 3, table);
            table = a * 4;
            Console.WriteLine("{0}*{1}={2}", a, 4, table);
            table = a * 5;
            Console.WriteLine("{0}*{1}={2}", a, 5, table);
            table = a * 6;
            Console.WriteLine("{0}*{1}={2}", a, 6, table);
            table = a * 7;
            Console.WriteLine("{0}*{1}={2}", a, 7, table);
            table = a * 8;
            Console.WriteLine("{0}*{1}={2}", a, 8, table);
            table = a * 9;
            Console.WriteLine("{0}*{1}={2}", a, 9, table);
            table = a * 10;
            Console.WriteLine("{0}*{1}={2}", a, 10, table);


        }
    }
}
