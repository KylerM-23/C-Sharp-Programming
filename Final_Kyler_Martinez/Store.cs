using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Kyler_Martinez
{
    public abstract class Store
    {
        //Any time units in the Store class are in minutes
        //Any time units for the child classes are in hours

        public char id { get; private set; }
        protected double lamda { get; private set;}
        protected double mu { get; private set; }
        protected double n { get; private set; }
        protected double p { get; private set; }
        public double response { get; protected set; }

        public Store(char i, double l, double m, double num)
        {
            id = i;
            lamda = l;
            mu = m;
            n = num;
            p = lamda / (n * mu);
        }

        public abstract double response_time();

        public static double operator +(Store s1, Store s2)
        {
            return s1.response + s2.response; 
        }
    }
}
