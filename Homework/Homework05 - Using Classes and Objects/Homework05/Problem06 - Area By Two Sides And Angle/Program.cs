using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem06___Area_By_Two_Sides_And_Angle
{
    class Triangle
    {
        double sideA;
        double sideB;
        double angle;
        public Triangle(double a, double b,double alfa)
        {
            this.sideA = a;
            this.sideB = b;
            this.angle = alfa;
        }
        public double Area()
        {
            double area = sideA * sideB * Math.Sin(angle * Math.PI / 180) / 2.0;
            return area;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            double angle = double.Parse(Console.ReadLine());
            Triangle inputTriangle = new Triangle(sideA, sideB, angle);
            Console.WriteLine("{0:F2}",inputTriangle .Area ());

        }
    }
}
