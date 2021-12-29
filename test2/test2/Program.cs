using System;

namespace test2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int id = Convert.ToInt32(Console.ReadLine());
            int Scores = Convert.ToInt32(Console.ReadLine());
            int[] times = new int[Scores];
            for (int i = 0; i < Scores; i++)
            {
                
                times[i] = Convert.ToInt32(Console.ReadLine());
            }
            Student s = new Student(firstName, lastName, id, times);
            s.printPerson();
            Console.WriteLine("Grade: " + s.calculate());
            Console.ReadLine();
        }
    }
    
}
