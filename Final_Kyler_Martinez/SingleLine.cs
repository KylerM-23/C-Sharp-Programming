using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Kyler_Martinez
{
    class SingleLine: Store
    {
        public SingleLine(char i, double l, double m, double num)
        : base(i, l/60, m/60, num)
        {
            response = response_time();
        }

        public override double response_time()
        {
            return (1 / (n * mu)) * (1 / (1 - p));
        }
    }
}
