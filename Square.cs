using System;

namespace square
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            HeaderFooter(n);

            for (int i = 0; i < n - 2; i++)
                MiddleRow(n);

            HeaderFooter(n);
        }

        static void HeaderFooter(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }

        static void MiddleRow(int n)
        {
            Console.Write('-');

            for (int i = 1; i<n; i++)
            {
                Console.Write(@"\/");
            }

            Console.WriteLine('-');
        }
    }
}
