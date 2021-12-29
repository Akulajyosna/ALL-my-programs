using System;
using System.Collections.Generic;
using System.Text;

namespace teams1
{
    class Myself
    {
        int rollnumber;
        string name;
        string coursejoin;
        int feepaidfar;


        public Myself(int rollnumber, string name, string coursejoin)
        {
            this.rollnumber = rollnumber;
            this.name = name;
            this.coursejoin = coursejoin;
        }
        public void Print()
        {
            Console.WriteLine("rollnumber: " +rollnumber);
            Console.WriteLine("name: " +name);
            Console.WriteLine("coursejoin: " +coursejoin);
            Console.WriteLine("feepaidfar: " + feepaidfar);
        }
        public void payment(int amount)
        {
            feepaidfar = feepaidfar + amount;
        }
        public int dueamount
        {
            get
            {
                return  Totalfee - feepaidfar;
            }
        }
        public int Totalfee
        {
            get
            {
                return coursejoin == "asp.net" ? 2000 : 3000;
            }

        }
    }
}

        

        
  

    




    



    

