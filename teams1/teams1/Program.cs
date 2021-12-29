using System;

namespace teams1
{
    class Program
    {
        static void Main(string[] args)
        {
            Myself t = new Myself( 01, "krishnasree","asp.net");
            t.payment(2000);
            t.Print();
            Console.WriteLine("dueamount = "+ t.dueamount);

            Myself myselfObj = new Myself(02, " jyoshnasree", "c#");
            myselfObj.payment(1500);
            myselfObj.Print();
            Console.WriteLine("dueamount= " + myselfObj.dueamount);
        }
    }
}
