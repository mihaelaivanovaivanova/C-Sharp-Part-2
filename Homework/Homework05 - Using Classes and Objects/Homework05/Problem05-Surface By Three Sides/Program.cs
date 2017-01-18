using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem05_Surface_By_Three_Sides
{
    class Triangle
    {
        public double sideA;
        public double sideB;
        public double sideC;
        public Triangle (double a,double b,double c)
        {
            this.sideA = a;
            this.sideB = b;
            this.sideC = c;
        }
        public double CalculatePerimeter()
        {
            double perimeter = (sideA + sideB + sideC) * 0.5;
            return perimeter;
        }
        public double CalculateArea()
        {
            double area = Math.Sqrt(CalculatePerimeter() * (CalculatePerimeter() - sideA) * (CalculatePerimeter() - sideB) * (CalculatePerimeter() - sideC));
            return area;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            double sideC = double.Parse(Console.ReadLine());
            Triangle inputTriangle = new Triangle(sideA, sideB, sideC);
            Console.WriteLine("{0:F2}",inputTriangle.CalculateArea());

        }
    }
}
