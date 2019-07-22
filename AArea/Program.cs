using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(7);
            Console.WriteLine(Math.Round(circle.GetArea()));
            Rectangle rect = new Rectangle(5,4);
            Square square = new Square(4);
            Triangle triangle = new Triangle(6,10);
        }
    }
}
