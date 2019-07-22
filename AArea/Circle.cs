using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AArea
{
    public class Circle:Shape
    {
        double radius;
        public Circle(double radius)
        {
            this.radius = radius;
            SetArea();
        }
        override
        public void SetArea()
        {
            area = (22 * radius * radius) / 7;
        }
        override
        public double GetArea()
        {
          
            return area;
        }
    }
}
