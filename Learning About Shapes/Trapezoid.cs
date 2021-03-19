using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_About_Shapes
{
    class Trapezoid
    {
        double side1 = 1, side2 = 1, side3 =1, p_base = 1, height = 1, area = 0, perimeter = 0;

        public string Area
        { get { return Convert.ToString(area); } }

        public string Perimeter
        { get { return Convert.ToString(perimeter); } }

        public string GenInfo
        {
            get { return "A trapezoid is a 4 sided shape with two parallel sides.\nA special form is a right trapezoid where one side is at a 90 degree angle with the base.\nThe area of a trapezoid is (a+b)*h/2 and the perimeter is a+b+c+d.\nTo explore the area or perimeter of your specific shape, please enter it in the boxes and press \"Generate Data\" to find out the properties of your shape.\nIf you have a right trapezoid put the same value for c and h.\nClick \"Go Home\" to explore other shapes."; }
        }

        private void calculateArea()
        {
            area = Math.Round(.5 * (p_base+side1) * height, 3);
        }

        private void calculatePerimeter()
        {
            perimeter = Math.Round(side1 + side2 + p_base + side3, 3);
        }


        public void setShape(double a, double b, double c, double d, double h)
        {
            side1 = a;
            side2 = c;
            side3 = d;
            p_base = b;
            height = h;
            calculateArea();
            calculatePerimeter();
        }

        public Trapezoid()
        {
            calculateArea();
            calculatePerimeter();
        }
    }
}

