using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_WAAS
{
    public abstract class WAAS
    {
        string region = "Earth";
        protected int satalities = 0;
        protected double probability = 0;
        protected double avalilability = 0;

        protected double factorial(int n)
        {
            int ans = 1;
            for (int i = 1; i <= n; i++)
            {
                ans = ans * i;
            }
            return ans;
        }
        protected double exponent(double a, int b)
        {
            double ans = 1;
            for (int i = 1; i <= b; i++)
            {
                ans = ans *a;
            }
            return ans;
        }

        protected double combination(int n, int m)
        {
            return (factorial(n))/((factorial(m))*factorial(n-m));
        }

        public WAAS(string r, int s, double p, double a)
        {
            region = r;
            satalities = s;
            probability = p;
            avalilability = a;
        }

        
        public abstract double availability_assess();

        public override string ToString()
        {
            return string.Format("A user in {0} has an avalilability of {1}.",region, avalilability);
        }
    }
}
