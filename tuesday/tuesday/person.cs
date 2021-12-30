using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace tuesday
{
    class person
    {
 
        public string Name { get; set; }
        public int Age { get; set; }


        public override string ToString()
        {
            return Name + " - " + Age;
        }


    }
}

