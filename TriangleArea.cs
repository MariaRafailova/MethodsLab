using System;

namespace TriangleArea
{
    class TriangleArea
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            Console.WriteLine(Area(a, h));
        }

        static double Area(double a, double h)
        {
            double area = a * h/ 2;
            return area;
        }
    }
}
