using System;
using System.Collections.Generic;
using System.Text;

namespace OOPintro
{
    class Person
    {
        string _name;
        
        int _age;

        Animal _pet;

        public Person(string name, int age, Animal pet)
        {
            _name = name;
            _age = age;
            _pet = pet;
        }

        public void Eat()
        {
            Console.WriteLine(_name +" is eating!");
        }

        public void Sleep()
        {
            Console.WriteLine(_name + " is sleeping!");
        }

    }
}
