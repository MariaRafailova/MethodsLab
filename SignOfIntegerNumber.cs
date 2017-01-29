using System;

namespace SignOfIntegerNumber
{
   
    class SignOfIntegerNumber
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintSign(n);
        }

        static void PrintSign(int num)
        {
            if (num > 0)
                Console.WriteLine($"The number {num} is positive.");

            if (num < 0)
                Console.WriteLine($"The number {num} is negative.");

            if (num == 0)
                Console.WriteLine($"The number {num} is zero.");
        }
    }
}
