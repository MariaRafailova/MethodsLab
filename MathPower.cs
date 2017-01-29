using System;

namespace MathPower
{
    class MathPower
    {
        static void Main()
        {
            double num = double.Parse(Console.ReadLine());
            int pow = int.Parse(Console.ReadLine());

            Console.WriteLine(Power(num, pow));
        }

        static double Power(double n, int p)
        {
            double result = Math.Pow(n, p);

            return result;
        }
    }
}
