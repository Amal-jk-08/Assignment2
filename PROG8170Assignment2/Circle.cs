using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG8170Assignment2
{
    public class Circle
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
            return(radius);
        }
        public void SetRadius(int radius1)
        {
            radius = radius1;
        }
        public double GetCircumference()
        {
            return(2 * 3.14 * radius);
        }
        public double GetArea()
        {
            return(3.14 * radius * radius);
        }
    }
}
