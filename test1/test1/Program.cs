using System;
using System.IO;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Id\t\tSource\t\tDestination\t\tDate\t\tStatus\t\tNetwork\t\t");
            FileStream filestreamObj = new FileStream("C:\\capgemini\\assigement1.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(filestreamObj);
            while (sr.Peek()> 0)
            {
                string readmyline = sr.ReadLine();
                string[] strings = readmyline.Split(':');
                if (strings.Length > 1)
                {
                    string data = strings[1].Split(' ')[0];
                    Console.Write(strings[1] + "\t\t");
                    
                }
                else
                {
                    Console.WriteLine();
                }


            }
        }
    }
}
