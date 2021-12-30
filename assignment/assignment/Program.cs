using System;

namespace assignment
{
    class Program
    {
        public static void Main()
            {
            String str = Console.ReadLine();
                SubString(str, str.Length);
            }
      
        public static void SubString(String str, int n)
        {
            for (int i = 0; i < n; i++)
                for (int j = 1; j <= n - i; j++)
                    Console.WriteLine(str.Substring(i, j));
        }



    }
}
