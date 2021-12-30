using System;
using System.Text;
using System.IO;

namespace ass1
{
       class Program
       {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("C:\\capgemini\\assigement1.txt", FileMode.Create, FileAccess.Write);
            StreamReader sr = new StreamReader(fs);
            while (sr.Peek() > 0)
            {
                string readmyline = sr.ReadLine();
                string[] strings = readmyline.Split(':');
                if (strings.Length > 1)
                    Console.WriteLine(strings[1]);


            }
        }
    }
}
