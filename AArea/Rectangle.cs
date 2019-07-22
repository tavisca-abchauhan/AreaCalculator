using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AArea
{
    public class Rectangle : Shape
    {
        double length;
        double breadth;
        public Rectangle(double length,double breadth)
        {
            this.length = length;
            this.breadth = breadth;
            SetArea();
        }
        override
        public void SetArea()
        {
            area = (double)(length * breadth);
        }
        override
        public double GetArea()
        {
            return area;
        }
    }
}