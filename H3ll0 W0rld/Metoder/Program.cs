using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;

namespace Metoder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 5, 7, 12 };
            string[] names = { "Gabriel", "Jacob", "Emil", "Theo", "Petter" };

            Console.WriteLine(addition(numbers));
            namereverse(names);
            
            int[] bigandsmall = bigsmall(numbers);

            for (int i = 0; i < bigandsmall.Length; i++)
            {
                Console.WriteLine(bigandsmall[i]);
            }
        }

        static int addition(int[] numbers)
        {
            var sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        static void namereverse(string[] names)
        {
            for (int i = 4; i >= 0; i--)
            {
                Console.WriteLine(names[i]);
            }
        }

        static int[] bigsmall(int[] numbers)
        {
            int biggest = numbers.Max();
            int smallest = numbers.Min();

            int[] biggestsmallest = { biggest, smallest };

            return biggestsmallest;

        }
    }
}
