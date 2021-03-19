using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_About_Shapes
{
    class Ellipse
    {
        double mjaxis = 1, miaxis=1, area = 1, perimeter = 0;

        public string Area
        { get { return Convert.ToString(area); } }

        public string Perimeter
        { get { return Convert.ToString(perimeter); } }

        public string GenInfo
        {
            get { return "An ellipse is a round shape with a minor and major axis.\nIf the major and minor axis are the same, the ellipse is a circle.\nThe area of an ellipse is pi*a*b.\nThere isn't an easy formula for the circumference so we approximate.\nTo explore the area or perimeter of your specific shape, please enter it in the boxes and press \"Generate Data\" to find out the properties of your shape.\nClick on the circle button to learn more about that shape or click \"Go Home\" to explore other shapes."; }
        }

        public string CInfo
        {
            get { return "A circle is a round shape we see in our everday lives.\nThe area of a circle is pi*r*r and the circumference is 2*pi*r.\nTo explore the area or perimeter of your specific shape, please enter it in the boxes and press \"Generate Data\" to find out the properties of your shape.\nClick \"Go Home\" to explore other shapes."; }
        }

        private void calculateArea()
        {
            area = Math.Round(Math.PI * mjaxis * miaxis,3);
        }

        private void calculatePerimeter()
        {
            if (mjaxis == miaxis)
            {
                perimeter = Math.Round(2*Math.PI * mjaxis,3);
            }
            else
            {
                double h = (Math.Pow(Math.Abs(mjaxis - miaxis), 2)) / (Math.Pow(Math.Abs(mjaxis + miaxis), 2));
                perimeter = Math.Round(Math.PI * Math.Abs(mjaxis + miaxis) *(1+((3*h)/(10+(Math.Sqrt(4-3*h))))),3);
            }
        }


        public void setShape(double a, double b)
        {
            mjaxis = a;
            miaxis = b;
            calculateArea();
            calculatePerimeter();
        }


        public Ellipse()
        {
            calculateArea();
            calculatePerimeter();
        }
    }
}
