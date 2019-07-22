using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AArea
{
    public class Square : Shape
    {
        double side;
        public Square(double side)
        {
            this.side = side;
            SetArea();
        }
        override
        public void SetArea()
        {
            area = side * side;
        }
        override
        public double GetArea()
        {
            return area;
        }
    }
}
