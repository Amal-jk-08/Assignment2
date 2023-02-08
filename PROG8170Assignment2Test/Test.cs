using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROG8170Assignment2;
using NUnit.Framework;

namespace PROG8170Assignment2Test
{
    public class test
    {
        [TestCase(6, 6, 37.68, 113.04)]
        [TestCase(3, 3, 18.84, 28.26)]
        [TestCase(5, 5, 31.4, 78.5)]
        public void TestGetRadius(int radius, int expectedRadius, double expectedCircumference,
double expectedArea)
        {
            Circle circle = new Circle();
            circle.SetRadius(radius);
            int actualResult = circle.GetRadius();
            Assert.AreEqual(expectedRadius, actualResult);
        }
        [TestCase(6, 6, 37.68, 113.04)]
        [TestCase(3, 3, 18.84, 28.26)]
        [TestCase(5, 5, 31.4, 78.5)]
        public void TestSetRadius(int radius, int expectedRadius, double expectedCircumference,
double expectedArea)
        {
            Circle circle = new Circle();
            circle.SetRadius(radius);
            int actualResult = circle.GetRadius();
            Assert.AreEqual(expectedRadius, actualResult);
        }
        [TestCase(6, 6, 37.68, 113.04)]
        [TestCase(3, 3, 18.84, 28.26)]
        [TestCase(5, 5, 31.4, 78.5)]
        public void TestGetCircumference(int radius, int expectedRadius, double expectedCircumference,
double expectedArea)
        {
            Circle circle = new Circle();
            circle.SetRadius(radius);
            double actualResult = circle.GetCircumference();
            Assert.AreEqual(expectedCircumference, actualResult, 0.01);
        }
        [TestCase(6, 6, 37.68, 113.04)]
        [TestCase(3, 3, 18.84, 28.26)]
        [TestCase(5, 5, 31.4, 78.5)]
        public void TestGetArea(int radius, int expectedRadius, double expectedCircumference,
double expectedArea)
        {
            Circle circle = new Circle();
            circle.SetRadius(radius);
            double actualResult = circle.GetArea();
            Assert.AreEqual(expectedArea, actualResult, 0.01);
        }
    }
}
