using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Kyler_Martinez
{
    class MultiLine: Store
    {
        public MultiLine(char i, double l, double m, double num)
        : base(i, l/60, m/60, num)// convert hours to minutes
        {
            response = response_time();
        }

        public override double response_time()
        {
            return (1 / mu) * (1 / (1 - p));
        }
    }
}
