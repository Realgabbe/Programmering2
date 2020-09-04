using System;

namespace H3ll0_W0rld
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("HEJSAN NIKLAS :)");

            Console.WriteLine("Vänligen fyll i ditt namn.");
            string namn = Console.ReadLine();

            Console.WriteLine("Vänligen fyll i din ålder.");
            int ålder = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Är du vid liv? Skriv 1 om du är vid liv och om du inte är vid liv skriv något annat tal.");
            Boolean levande = true;
            int svar = Convert.ToInt32(Console.ReadLine());
            if (svar == 1)
            {
                levande = true;
            }
            else
            {
                levande = false;
            }

            if (levande == true)
            {
                Console.WriteLine("Du är en levande person vars namn är " + namn + ". Du är " + ålder + " år gammal.");
            }
            else
            {
                Console.WriteLine("Du är en icke levande person vars namn är " + namn + ". Du är " + ålder + "  år gammal.");
            }

            Console.WriteLine("Skriv 1 om du vill gå till spelfredagen");
            var svar2 = Convert.ToInt32(Console.ReadLine());
            if (svar2 == 1)
            {
                Console.WriteLine("Varsågod att gå dit då");
            }
            else if (svar2 < 1)
            {
                Console.WriteLine("För lågt värde på ditt svar");
            }
            else
            {
                Console.WriteLine("För högt värde på ditt svar");
            }

            for (var i = 0; i <= 5; i++)
            {
                Console.WriteLine((5-i));
            }

            while (true)
            {
                Console.WriteLine("Hej");
                break;
            }

            Console.WriteLine("Skriv '1' för ett svar och skriv '2' för ett annat");
            var svar4 = Convert.ToInt32(Console.ReadLine());
            switch (svar4)
            {
                case 1:
                    Console.WriteLine("Hejsan");
                    break;

                case 2:
                    Console.WriteLine("Basjk");
                    break;

                    
            }

        }
    }
}
