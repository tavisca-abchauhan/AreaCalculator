using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AArea;

namespace AAreaTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCircle()
        {
            Circle circle;
            circle = new Circle(7);
            Console.WriteLine(Math.Round(circle.GetArea()));
            Assert.AreEqual(154, Math.Round(circle.GetArea(),2));
        }
        [TestMethod]
        public void TestRectangle()
        {
            Rectangle rectangle;
            rectangle = new Rectangle(5,4);
            Assert.AreEqual(20, Math.Round(rectangle.GetArea(),2));
        }

        [TestMethod]
        public void TestSquare()
        {
            Square square;
            square = new Square(5);
            Assert.AreEqual(25, Math.Round(square.GetArea(),2));
        }
        [TestMethod]
        public void TestTriangle()
        {
            Triangle triangle;
            triangle = new Triangle(5,4);
            Assert.AreEqual(10, Math.Round(triangle.GetArea(),2));
        }
    }
}
