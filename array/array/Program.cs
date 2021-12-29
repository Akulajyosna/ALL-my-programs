using System;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            int max1 = 0;
            int max2 = 0, n = 3;
            int[] arr=new int[20];
            Console.Write("enter the array elemnts:\n");
            for (int i = 0; i < n; i++)
            
            { 
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0;i<n;i++)
                if(arr[i]>max1)
            {
                    max2 = max1;
                    max1 = arr[i];
                 
            }
            else if(arr[i]>max2)
                {
                    max2 = arr[i];

                }
            Console.WriteLine("second highest: {0}",max2);


        }
    }
}
