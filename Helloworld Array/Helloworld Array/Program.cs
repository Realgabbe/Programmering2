using System;

namespace Helloworld_Array
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] namn = new string[5];

            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("Input a name " + (5 - i) + " more times.");
                namn[i] = Console.ReadLine();
            }

            for (int i = 4; i >= 0; i--)
            {
                Console.WriteLine(namn[i]);
            }
        }
    }
}
