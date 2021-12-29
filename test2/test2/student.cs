using System;
using System.Collections.Generic;
using System.Text;

namespace test2
{


    class Student : Person
    {
        public int[] marks;
        public Student(string firstName, string lastName, int id, int[] marks)
            : base(firstName, lastName, id)
          
        {
            this.marks = marks;
            this.firstName = firstName;
            this.lastName = lastName;
            this.idNumber = id;
        }
        public char calculate()
        {
            int avg= 0;
            int sum = 0;
            char grade = ' ';
            for (int i = 0, length = this.marks.Length; i < length; i++)
            {
                sum = sum+this.marks[i];
            }
            avg = sum / this.marks.Length;
            if (90 <= avg && avg <= 100)
            {
                grade = 'O';
            }
            else if (80 <= avg && avg < 90)
            {
                grade = 'E';
            }
            else if (70 <= avg && avg < 80)
            {
                grade = 'A';
            }
            else if (55 <= avg && avg < 70)
            {
                grade = 'P';
            }
            else if (40 <= avg && avg < 55)
            {
                grade = 'D';
            }
            else
            {
                grade = 'T';
            }
            return grade;
        }
    }
}
