using System;
using System.Collections.Generic;
using System.Text;

namespace thursday2
{
    class Couseonline:Corseoffline
    {
        protected double charge;
        public Couseonline(string name, int duration, int fee) : base(name, duration, fee)
        {
            charge = 10;
        }


        public override double GetTotalFee()
        {
            var total = fee * duration;
            return total + (total * charge / 100);
        }
    }
}

