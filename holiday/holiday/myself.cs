using System;
using System.Collections.Generic;
using System.Text;

namespace holiday//polymorphism-overloading,overriding;
  //method overloading- creating multiple methods in a class with same names but different parameters;
{
    public class myself
    {
        public void test()
        
        {
            Console.WriteLine("hi");                                     // test();
           
            
        }
        public void test(int i)
        {                                                                
            Console.WriteLine("capgemini");                             //test(int i);
        }
        public void test(int i, string s)
        {
            Console.WriteLine("friends");                               ///test( int a,string a);
        }
        public void test(string s,int i )
        {
            Console.WriteLine("welcome");                              //test( string a,int a); 
        }
        public void test(string s)
        {
            Console.WriteLine("to all");                             //test(string a) ;   
        }



    }
}
