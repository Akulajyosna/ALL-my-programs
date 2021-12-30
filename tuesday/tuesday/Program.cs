using System;
using System.Collections;


namespace tuesday
{
    class Program
    { 
        static void Main(string[] args)
        {

            ArrayList list = new ArrayList();

            int total = 3;
            for (int i = 0; i < total; i++)
            {
                string name = Console.ReadLine();
                int age = int.Parse(Console.ReadLine());

                list.Add(new person()
                {
                    Name = name,
                    Age = age
                });
            }

            foreach (person p in list)
            {
                Console.WriteLine(p.ToString());
            }

            Console.ReadLine();

        }
    }
}
