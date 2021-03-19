using System;
using System.Collections.Generic;
using System.Text;

namespace Learning_About_Shapes
{
    class Parallelogram
    {
        double side = 1, p_base = 1, height = 1, area = 0, perimeter = 0;

        public string Area
        {get { return Convert.ToString(area); }}

        public string Perimeter
        { get { return Convert.ToString(perimeter); } }

        public string GenInfo
        {
            get { return "A parallelogram is a 4 sided shape with two sets of parallel sides.\nTwo special forms of a parallelogram are the square and rectangle.\nThe area of a general parallelogram is b* h and the perimeter is 2 * (a+b).\nTo explore the area or perimeter of your specific shape, please enter it in the boxes and press \"Generate Data\" to find out the properties of your shape.\nClick on the square and rectangle buttons to learn more about those shapes or click \"Go Home\" to explore other shapes."; }
        }

        public string SquInfo
        {
            get { return "A square is a 4 sided shape with 4 equal sides sides.\nIt has four 90 degree angles.\nThe area of a square is a*a and the perimeter is 4*a.\nTo explore the area or perimeter of your specific square, please enter it in the boxes and press \"Generate Data\" to find out the properties of your shape.\nClick \"Go Home\" to explore other shapes."; }

        }

        public string RecInfo
        {
            get { return "A rectangle is a 4 sided shape with two sets of equal sides.\nIt has four 90 degree angles like a square.\nThe area of a rectangle is w*l and the perimeter is 2*(w+l).\nTo explore the area or perimeter of your specific shape, please enter it in the boxes and press \"Generate Data\" to find out the properties of your shape.\nClick \"Go Home\" to explore other shapes."; }

        }

        private void calculateArea()
        {
            area = Math.Round(p_base * height, 3);
        }

        private void calculatePerimeter()
        {
            perimeter = Math.Round(2 * (side + p_base),3);
        }


        public void setShape(double s, double b, double h)
        {
            side = s;
            p_base = b;
            height = h;
            calculateArea();
            calculatePerimeter();
        }

        public Parallelogram()
        {
            calculateArea();
            calculatePerimeter();
        }
        public Parallelogram(double s, double b, double h)
        {
            side = s;
            p_base = b;
            height = h;
            calculateArea();
            calculatePerimeter();
        }

    }
}
