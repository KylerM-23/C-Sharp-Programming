using System;
using System.Collections.Generic;
using System.Text;

namespace ECE2310_Midterm_2
{
    //Creates a class that models a person's account.
    class Investor
    {
        Stock stock1 = null; //Tesla
        Stock stock2 = null; //Apple

        public static int PeriodLength { get; private set; } //keeps track of the start for all investors.
        public double AveWorth { get; private set; }

        public string InvestorName { get; private set; }

        public int Assets { get; private set; }

        int max_assest = 0;

        int min_assest = 0;

        int running_total = 0; //keeps track of the total worth sum

        int mmx = 0, dmx = 0, ymx = 0; //max day
        int mmn = 0, dmn = 0, ymn = 0; //min day

        public string max_asset_info() //Returns string showing max info
        {
            return string.Format("{0} made had the highest assests on {1}/{2}/{3} with a total of ${4}.", InvestorName, mmx, dmx, ymx, max_assest);
        }

        public string min_asset_info() //Returns string showing min info
        {
            return string.Format("{0} made had the lowest assests on {1}/{2}/{3} with a total of ${4}.", InvestorName, mmn, dmn, ymn, min_assest);
        }

        public void closing_assets(int m1, int d1, int y1)
        {
            if (min_assest <= 0) //prevents 0 from being the min
            {
                min_assest = Assets;
            }

            Assets = stock1.StockPrice * stock1.NumOfStock + stock2.StockPrice * stock2.NumOfStock;
            if (Assets > max_assest)
            {
                mmx = m1;
                dmx = d1;
                ymx = y1;
                max_assest = Assets;

            }
            
            if (Assets < min_assest)
            {
                mmn = m1;
                dmn = d1;
                ymn = y1;
                min_assest = Assets;

            }
            PeriodLength++;
            running_total = running_total + Assets;
            AveWorth = Convert.ToDouble(running_total) / PeriodLength;
        }

        public void buystock(string stok, int num)
        {
            if (stok == "T")
            {
                stock1.changenum(num);
            }
            else if (stok == "A")
            {
                stock2.changenum(num);
            }
        }

        public Investor(string iname, Stock s1, Stock s2)
        {
            InvestorName = iname;
            stock1 = s1;
            stock2 = s2;
            PeriodLength = 0;
        }

        public override string ToString() //Returns string showing the investor worth
        {
            return string.Format("{0} is worth ${1}.", InvestorName, Assets);
        }
    }
}
