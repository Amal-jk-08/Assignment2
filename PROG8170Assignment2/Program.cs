using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG8170Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int v;
            int radius,radius2;
            do
            {
                Console.WriteLine("Please enter the radius of the circle:");
                radius = int.Parse(Console.ReadLine());
                if(radius<=0)
                {
                    Console.WriteLine("Invalid Input. Enter a value greater than zero");
                }
            }while(radius<=0);
            Circle circle = new Circle(radius);
            do
            {
                Console.WriteLine("1.Get Circle Radius");
                Console.WriteLine("2.Change Circle Radius");
                Console.WriteLine("3.Get Circle Circumference");
                Console.WriteLine("4.Get Circle Area");
                Console.WriteLine("5.Exit");
                Console.WriteLine("Enter the number of the action you want to perform:");
                v = int.Parse(Console.ReadLine());
                switch (v)
                {
                    case 1: int r=circle.GetRadius();
                        Console.WriteLine(r);
                        break;
                    case 2: 
                        do
                        {
                            Console.WriteLine("Enter the new radius");
                            radius2 = int.Parse(Console.ReadLine());
                            if (radius2<=0)
                            {
                                Console.WriteLine("Invalid Input. Enter a value greater than zero");
                            }
                        }while(radius2<=0);
                        
                        circle.SetRadius(radius2);
                        break;
                    case 3: double c=circle.GetCircumference();
                        Console.WriteLine(c);
                        break;
                    case 4: double a=circle.GetArea();
                        Console.WriteLine(a);
                        break;
                    case 5: System.Environment.Exit(0);  
                        break;
                    default: Console.WriteLine("Invalid Input");
                        break;

                }

            }while(v!=5);



        }
    }
}
