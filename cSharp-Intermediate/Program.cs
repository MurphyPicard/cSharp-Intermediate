using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Intermediate
{

    public class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }

        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;
            return person;



        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Because we made Parse a static method
            var bob = Person.Parse("Bob");
            bob.Introduce("Ara");

            //var bob = new Person();
            //bob.Name = "Bob";
            //bob.Introduce("Ara");
        }
    }
}
