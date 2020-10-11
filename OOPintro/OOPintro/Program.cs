using System;

namespace OOPintro
{
    class Program
    {
        static void Main(string[] args)
        {

            Animal Hjelm = new Animal();
            Hjelm._name = "Hjelm";
            Hjelm._species = "Monke";
            Hjelm._color = "BLACK";

            Person Niklas = new Person("Niklas", 33, Hjelm);

            Niklas._pet = Hjelm;
            Niklas.Eat();
            Niklas.Sleep();

            Niklas._pet.Poop();

            Console.WriteLine("Hello World!");
        }
    }
}
