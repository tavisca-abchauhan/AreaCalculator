using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AArea
{
    public abstract class Shape
    {
        public double area;
        public Shape()
        {
            area = 0.0;
        }
        public abstract double GetArea();
        public abstract void SetArea();
    }
}
