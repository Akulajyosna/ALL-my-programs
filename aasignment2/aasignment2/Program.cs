using System;

namespace aasignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter your string : ");
            string[] s = Console.ReadLine().Split(' ');

            string ans = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                ans += s[i] + " ";
            }
            Console.Write("Reversed String:\n");
            Console.Write(ans.Substring(0,
                                        ans.Length - 1));
        }
    }
}
