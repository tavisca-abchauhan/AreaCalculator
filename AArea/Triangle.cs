using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AArea
{
    public class Triangle : Shape
    {
        double basee;
        double height;
        public Triangle(double basee,double height)
        {
            this.basee = basee;
            this.height = height;
            SetArea();
        }
        override
        public void SetArea()
        {
            area = (basee * height)/2;
        }
        override
        public double GetArea()
        {
            return area;
        }
    }
}