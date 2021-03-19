using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_About_Shapes
{
    class RegularPolygon
    {
        double side = 1,n = 1, area = 1, perimeter = 0;

        public string Area
        { get { return Convert.ToString(area); } }

        public string Perimeter
        { get { return Convert.ToString(perimeter); } }

        public string GenInfo
        {
            get { return "A regular polygon has n sides that are equal length.\nSome common polygons are pentagons, hexagons, and octagons.\nThe perimeter of a regular polygon is n*a but the area is more complicated to calculate.\nTo explore the area or perimeter of your specific shape, please enter it in the boxes and press \"Generate Data\" to find out the properties of your shape.\nEx: To have an octagon, n is equal to 8 meaning it has 8 sides.\nClick \"Go Home\" to explore other shapes."; }
        }

        private void calculateArea()
        {
            area = Math.Round((side*side*n)/(4*Math.Tan(Math.PI/n)),3);
        }

        private void calculatePerimeter()
        {
            perimeter = Math.Round(n*side, 3);
          
        }


        public void setShape(double s, double num)
        {
            side = s;
            n = num;
            calculateArea();
            calculatePerimeter();
        }


        public RegularPolygon()
        {
            calculateArea();
            calculatePerimeter();
        }
    }
}
