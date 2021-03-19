using System;

//ECE2310 Midterm 1: Kyler Martinez

namespace ECE2310_Midterm_1
{
    class Program
    {
        //I passed the Random object so I did not have to make many instances, 
        //this is more for the recursive function. I liked the number_x name.

        static double testLoop(int n, Random number_x)
        {
            double sum = 0, num = 0;
            
            for (int i = 0; i < n; i++)
            {
                num = number_x.Next(1000, 5001);
                Console.WriteLine(num);
                sum = sum + num;
            }
            return sum / n;
        }

        //count is a parameter which will allow me to reach my base case,
        //I wanted to keep my code mostly the same. n is used when computing the mean
        //temp is for storage and did not want to continue declaring it.
        //sum is the sum at the current moment.
        
        static double testRecursive(int n, int count, int temp, double sum, Random number_x)
        {
            if (count == 0)
            {
                return sum / n;
            }

             temp = number_x.Next(100, 1001);
             Console.WriteLine(temp);
            
            return testRecursive(n,count -1,0,sum + temp, number_x);
        }

        static void Main(string[] args)
        {
            int n = 10;
            Random number_x = new Random();
            Console.WriteLine("Ten randomly generated numbers of the range [1000,5000] will be displayed and the mean of those will be calculated using a for loop.\n");
            Console.WriteLine("The mean of those numbers is {0} .\n",testLoop(n,number_x));
            Console.WriteLine("Ten randomly generated numbers of the range [1000,5000] will be displayed and the mean of those will be calculated using a recursive function.\n");
            Console.WriteLine("The mean of those numbers is {0} .\n",testRecursive(n, n, 0, 0, number_x));
        }
    }
}
