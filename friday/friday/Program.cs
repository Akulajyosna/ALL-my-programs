using System;

namespace friday
{
    class Program
    {
        static void Main(string[] args)
        {
            code o = new code();
            Console.WriteLine(o.SuccessRate(10));
            Console.WriteLine(o.productionrateperhour(6));
            Console.WriteLine(o.workingitemsperminute(6));
            Console.ReadLine();
        }
    }
}
