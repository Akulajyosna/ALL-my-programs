using System;

namespace thursday2
{
    class Program
    {
        static void Main(string[] args)
        {
            var Course = new Course("data", 10, 100);
            var Corseoffline = new Corseoffline("parent", 10, 100);
            var Couseonline = new Couseonline("child", 10, 100);


            Course.Print();
            Corseoffline.Print();
            Couseonline.Print();

        }
    }
}
