using System;
using System.Collections.Generic;
using System.Text;

namespace friday
{
    public class code
    {
        public static int hours = 221;
        public double SuccessRate(int speed)
        {
            if (speed >= 1 && speed <= 4)
            {
                return 1.0;
            }
            if (speed >= 5 && speed <= 8)
            {
                return 0.9;
            }
            if (speed <= 9)
            {
                return 0.8;
            }
            if (speed == 10)
            {
                return 0.77;

            }
            return speed;
        }
        public double productionrateperhour(int speed)
        {
            return hours * speed * SuccessRate(speed);
        }
        public int workingitemsperminute(int speed)
        {
            return (int)productionrateperhour(speed) / 60;
        }

    }
}

