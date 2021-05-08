using System;
using System.Collections.Generic;
using System.Text;

//Each stock object encompasses all shares of a stock
namespace ECE2310_Midterm_2
{
    class Stock 
    
    {
        //static member of the random object. This is so I do not need to intilize a new for each stock.
        public static Random datapick = new Random(); 

        public string StockName { get; private set; }

        public int StockPrice { get; private set; }

        public int NumOfStock { get; private set; }

        public Stock(string sname, int price, int num)
        {
            StockName = sname;
            StockPrice = price;
            NumOfStock = num;
            
        }

        public void changestockprice(int min, int max)
        {
            StockPrice = datapick.Next(min, max +1);
        }

        public void changenum(int a)
        {
            NumOfStock = NumOfStock + a;
        }

        public override string ToString() //Returns string showing the price of the stock
        {
            return string.Format("{0} is worth ${1}.", StockName, StockPrice ) ;
        }
    }
}
