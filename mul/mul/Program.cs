using System;

namespace mul
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.Write("num1:");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("num2:");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("num3:");
            num3 = int.Parse(Console.ReadLine());
            int result = ((num1+num2)*num3);
            int result2 = num1 * num2 + num2 * num3;
            Console.WriteLine("s:" +result2);
            Console.WriteLine("s" +result);
        }
    }
}
