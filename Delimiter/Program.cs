using System;
using System.Linq;

namespace Delimiter
{
    class Program
    {
        static void Main(string[] args)
        {
            string raw = @"26.4
13
14
10
34.4	20	18	20
26.4	20	15	18
32.5	20	20	20
26.1	9	6	9
35.2	20	20	20
30.4	19	20	20
29.1	8	10	10
30.7	20	10	20
33.2	18	8	16
27.7	18	20	12
21.1	10	13	10
36.3	20	20	20
39.2	20	20	20
32.3	19	20	20
26.7	18	7	12
26.4	8	0	12
35.7	20	20	20
31.2	20	18	16
32	14	10	12
35.5	18	15	12
22.4	10	7	0
29.9	20	18	10
33.6	20	8	20
24.8	10	0	10
39.5	20	20	20
26.8	5	9	8
22.4	18	15	16
35.7	12	14	10
";
            string commastrin = raw.Replace('\t', ',').Replace('\n', ',');
            string temp = "";
            int pos = 0;
            double[] numarray = new double[200];
            char[] acceptablearray = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '.', ',' };
            for (int i = 0; i < commastrin.Length; i++)

            {
                if (acceptablearray.Contains(commastrin[i]))
                {
                    if (commastrin[i] == ',')
                    {
                        
                        numarray[pos] = Convert.ToDouble(temp);
                        //Console.WriteLine(temp);
                        pos++;
                        
                        temp = "";
                    }

                    else
                    {
                        temp = temp + commastrin[i];
                    }
                }
            }

            for (int i = 0; i < pos; i++)
            {
                Console.WriteLine("Data Point {0}: {1}", i+1, numarray[i]);
            }
        }
    }
}

