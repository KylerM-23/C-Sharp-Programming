using System;

namespace Exercise_4__EulersMethod
{
    class Program
    {
    static double EulerMethod(double tf, double y0, double h, double t)
    {
        

        if (t >= tf)
        {
            return y0;
        }
        else
        {
            double yn = y0 + h * 3 * t * t;
            return EulerMethod(tf, yn, h, t + h);
        }
    }

    static void print(string s)
    {
        Console.WriteLine(s);
        return;
    }
    static double input(string s)
    {
        print(s);
        return Convert.ToDouble(Console.ReadLine());
    }
    static void Main(string[] args)
        {
            double h = .1, tf = 1, y0 = 0;
            print("Welcome to the Euler's Method Calculator For The Equation dy/dx = 3x^2.");
            tf = input("Please enter the time you want to estimate: ");
            h = .001;
            y0 = input("Please enter the intial condition for the differential equation at y(0)");
            print(Convert.ToString(EulerMethod(tf,y0, h, h)));
            
        }
    }
}
