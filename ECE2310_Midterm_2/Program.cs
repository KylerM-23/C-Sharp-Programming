using System;

namespace ECE2310_Midterm_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock Tesla = new Stock("Tesla Inc.", 0, 0);
            Stock Apple = new Stock("Apple Inc.", 0, 0);

            Investor invest = new Investor("Kyler", Tesla, Apple);
            //I put my own name in there because I thought it was funny.

            invest.buystock("T", 2);
            invest.buystock("A", 10);
            //allows for the number of stock owned to change.

            int m = 3, d = 15, y = 2021; //I did not want to use the Date object so I did it the lazy way

            for (int i = 0; i < 5; i++)
            {
                Tesla.changestockprice(630,650); //Daily random change
                Apple.changestockprice(110, 130); //Daily rnadom change

                Console.WriteLine("Today on {0}/{1}/{2}, we have the following prices.", m, d, y);
                Console.WriteLine("{0}\n{1}", Tesla, Apple); //Prints stock info
                invest.closing_assets(m, d, y);
                Console.WriteLine("{0}\n",invest); //I wanted a new line
                d++;

            }
            Console.WriteLine(invest.max_asset_info()); //shows the max info
            Console.WriteLine(invest.min_asset_info()); //shows the min info
            Console.WriteLine("{0} was worth an average of ${1} over the {2} day period.", invest.InvestorName, invest.AveWorth, Investor.PeriodLength);
            //Shows the ave. info

        }
    }
}


/*
 These are personal notes - Kyler
 Q1: What is the average (total) assets of the investment during this period?
Line 35 will output this

Q2: Which day will the invester have the highest asset?  How much is it?
line 33 will output this

Q3: Which day will the invester have the least amount of assets? How much is it?
line 34 will output this

Requirements:

1. The project must apply encapsulation, e.g., using classes  
I used the classes Stock & Investor.

2. The project must apply composition
Investor has a data member for each stock object.

3. The project must use ToString method(s) to print out information
I have one in both Investor & Stock to print general info.

4. The project must demonstrate the use of static member(s)
I have a static member for the random object in Stock and for the period length in Investor.

5. The project must answer the above questions correctly.


Notes:
I could improve using an array to keep track of stocks whihc will allow for n stock as opposed to the hardcoded 2.
 */