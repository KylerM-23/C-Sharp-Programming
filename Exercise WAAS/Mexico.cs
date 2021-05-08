using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_WAAS
{
    class Mexico : WAAS
    {
        public Mexico()
        : base("Mexico", 5, .999, 0)
        {
            avalilability = availability_assess();
        }

        public override double availability_assess()
        {
            double ans = 0;
            for (int i = 4; i <= satalities; i++)
            {
                ans = ans + combination(satalities, i) * exponent(probability, i) * exponent(1 - probability, satalities - i);
            }
            return ans;
        }
    }
}
