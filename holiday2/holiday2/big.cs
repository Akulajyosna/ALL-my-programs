using System;
using System.Collections.Generic;
using System.Text;

namespace holiday2//method overriding- having two methods with same name and same parameters
                  //one should be in the base class and other method should be in a child class
                  //Virtual and Override keywords are used to achieve method overriding.//
{
    public class big
    {
        public  virtual void show()
        {
            Console.WriteLine("my name is mayareddy");
        }
        public void test()
        {
            Console.WriteLine("i am from ap");
        }
    }
    public  class small:big
    {
        public override   void show()
       {
           Console.WriteLine(" hi all");
        }

    }

}
