using System;

namespace GreaterOfTwo
{
    class GreaterOfTwo
    {
        static void Main()
        {
            var type = Console.ReadLine();

            switch (type)
            {
                case "int":
                    {
                        var first = int.Parse(Console.ReadLine());
                        var second = int.Parse(Console.ReadLine());
                        Console.WriteLine(GetMax(first, second));
                        break;
                    }
                case "char":
                    {
                        var first = char.Parse(Console.ReadLine());
                        var second = char.Parse(Console.ReadLine());
                        Console.WriteLine(GetMax(first, second));
                        break;
                    }

                case "string":
                    {
                        var first = Console.ReadLine();
                        var second = Console.ReadLine();
                        Console.WriteLine(GetMax(first, second));
                        break;
                    }
            }           

        }

        static int GetMax(int first, int second)
        {
           return Math.Max(first, second);
        }

        static char GetMax(char first, char second)
        {
            if (first>second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }

        static string GetMax(string first, string second)
        {
            if (first.CompareTo(second) >= 0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
    }
}
