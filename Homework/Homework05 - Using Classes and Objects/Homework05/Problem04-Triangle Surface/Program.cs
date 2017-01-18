using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04_Triangle_Surface
{
    class TriangleParameters
    {
        public double side;
        public double altitude;
        public TriangleParameters(double s, double a)
        {
            this.side = s;
            this.altitude = a;
        }
        public double CalculateArea()
        {
            double area = side * altitude / 2.0;
            return area;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double side = Double.Parse(Console.ReadLine());
            double altitude = Double.Parse(Console.ReadLine());
            TriangleParameters triangle = new TriangleParameters(side, altitude);
            Console.WriteLine("{0:F2}",triangle.CalculateArea());

        }
    }
}
