using System;
using System.Collections.Generic;
using System.Text;

namespace thursday2
{
    class Course
    {

        protected string name;
        protected int duration;
        protected int fee;


        public Course(string name, int duration, int fee)
        {
            this.name = name;
            this.duration = duration;
            this.fee = fee;
        }


        public void Print()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Duration: " + duration.ToString());
            Console.WriteLine("Fee: " + fee.ToString());
            Console.WriteLine("Total fee: " + GetTotalFee().ToString());
        }


        public virtual double GetTotalFee()
        {
            return fee * duration;
        }
    }

}
