using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG8170Assignment2
{
    public internal class Circle
    {
        int radius;
        public Circle()
        {
            radius = 1;
        }
        public Circle(int r)
        {
            radius = r;
        }
        public int GetRadius()
        {
            Console.WriteLine("Radius of the circle is"+radius);
        }
        public void SetRadius(int radius1)
        {
            radius = radius1;
        }
        public double GetCircumference()
        {
            Console.WriteLine("Circumference of the circle is"+(2*3.14*radius));
        }
        public double GetArea()
        {
            Console.WriteLine("Area of the circle is"+(3.14*radius*radius));
        }
    }
}
