using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace test2
{
     public class Person
    {
       protected string firstName;
        protected string lastName;
        protected int idNumber;
        public Person(String firstName, String lastName, int identification)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.idNumber = identification;
        }
        public void printPerson()
        {
            Console.WriteLine("name: " + firstName +lastName);
            Console.WriteLine("IDnumber: " + idNumber);

        }

    }

}

