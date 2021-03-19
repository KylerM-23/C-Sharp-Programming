using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_About_Shapes
{
    class Triangle
    {
        double side1 = 1, side2 = 1, p_base = 1, height = 1, area = 0, perimeter = 0;

        public string Area
        { get { return Convert.ToString(area); } }

        public string Perimeter
        { get { return Convert.ToString(perimeter); } }

        public string GenInfo
        {
            get { return "A triangle is a 3 sided shape.\nIf all sides are equal, the triangle is equilateral, if two sides are equivalent, it is isosceles, and scalene if all sides are different.\nThe area of a triangle is b* h/2 and the perimeter is a+b+c.\nTo explore the area or perimeter of your specific shape, please enter it in the boxes and press \"Generate Data\" to find out the properties of your shape.\nClick on the right triangle button to learn more about that triangle or click \"Go Home\" to explore other shapes."; }
        }

        public string RTInfo
        {
            get { return "A right triangle has one right degree angle and the pythagorean theorem is an important tool that helps find the sides of a triangle.\nThe area of a triangle is a* b/2 and the perimeter is a+b+c.\nTo explore the area or perimeter of your specific shape, please enter it in the boxes and press \"Generate Data\" to find out the properties of your shape.\nClick \"Go Home\" to explore other shapes."; }
        }

        private void calculateArea()
        {
            area = Math.Round(.5*p_base * height,3);
        }

        private void calculatePerimeter()
        {
            if (side1 == 0)
            {
                perimeter = Math.Round(height + side2 + p_base,3);
            }
            else
            {
                perimeter = side1 + side2 + p_base;
            }
        }


        public void setShape(double a, double b, double c, double h)
        {
            side1 = a;
            side2 = c;
            p_base = b;
            height = h;
            calculateArea();
            calculatePerimeter();
        }

        public void setShape(double a, double b, double c)
        {
            side1 = 0;
            side2 = c;
            p_base = b;
            height = a;
            calculateArea();
            calculatePerimeter();
        }

        public Triangle()
        {
            calculateArea();
            calculatePerimeter();
        }
    }
}
