using System;

namespace Final_Kyler_Martinez
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleLine s1 = new SingleLine('A',6,2,4);
            MultiLine s2 = new MultiLine('B', 18, 2, 12);
            MultiLine s3 = new MultiLine('C', 6, 4, 20);
            SingleLine s4 = new SingleLine('D', 10, 3, 15);
            MultiLine s5 = new MultiLine('E', 15, 5, 60);
            MultiLine s6 = new MultiLine('F', 15, 4, 45);
            Store[] stores = new Store[] {s1,s2,s3,s4,s5,s6 };
            Console.WriteLine("Stores in alphabetical order.");
            display_stores(stores);
            sorting(stores);
            Console.WriteLine();//I wanted the gap.
            Console.WriteLine("Stores arranged by response time.");
            display_stores(stores);
            Console.WriteLine();//I wanted the gap.
            Console.WriteLine("If someone goes to store {0} and then to store {1}. The total response time is {2}.", s3.id, s4.id, s3 + s4);
        }

        public static void display_stores(Store[] storelist)
        {
            foreach (Store i in storelist)
            {
                Console.WriteLine("Store {0} has a response of {1} minutes.", i.id, i.response_time()); //output info
            }
        }

        public static void sorting(Store[] storelist)
        {
            int n = storelist.Length;
            Store temp = null;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (storelist[j].response < storelist[i].response)
                    {
                        temp = storelist[j];
                        storelist[j] = storelist[i];
                        storelist[i] = temp;
                    }
                }
            }
        }
    }
}

/*
 * Abstract class Store acts as the parent and the childern are MultiLine & SingleLine
 * 
 * Polymorphism is seen since each child has a different implementation of the response time method
 * and while in an array they use that specific one. I explicty called the response_time method to better
 * show dynamic binding, originally I just stored the response in a variable and called it.
 * 
 * See Q3 for operator overloading
 * 
 * Q1: A foreach loop is made that iterates through an array of stores to output the data which was formatted by
 * Note: the response times are not rounded and I did not want to mess with the NET type and select the wrong one, sorry about that.
 *
 * Q2: The method sorting takes in an array of stores and then sorts them so that the array begins at the lowest response time and ascends from there. 
 * 
 * Q3: Through operator overloading, when two stores are added, the response times are added and returned.
 * This was done using the store class to allow for stores of differing types to be added.
 */