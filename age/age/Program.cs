using System;

namespace age
{
    class Program
    {
        static void Main()
        {
            int age;
            Console.Write("age:");
            age = Convert.ToInt32(Console.ReadLine());
            if (age < 25)
            {
                Console.WriteLine("you are young");

            }
            else
            {
                Console.WriteLine("you are old");
            }
            Console.ReadLine();


        }
    }
}
