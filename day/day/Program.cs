using System;

namespace day
{
    class Program
    {
        static void Main(string[] args)
        {
            string revstr = "";
            string str = Console.ReadLine();            
                for (int i = str.Length - 1; i >= 0; i--)
             
                if(str[i]!='')
            {
                revstr = revstr + str[i];

            }
            Console.WriteLine(revstr);
            Console.ReadLine();

        }
        
    }
}
