using System;
using System.Collections.Generic;
using System.Text;

namespace thursday2
{
    class Corseoffline:Course
    {
        protected int discount;
        public Corseoffline(string name, int duration, int fee) : base(name, duration, fee)
        {
            discount = 10;
        }


        public override double GetTotalFee()
        {
            var total = fee * duration;
            return total - (total * discount / 100);
        }
    }



}

