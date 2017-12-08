using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Intermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            // Need to see the ildasm for Birthdate

            var person = new Person();
            person.Birthdate = new DateTime(1980, 8, 7);
            Console.WriteLine(person.Age);
        }
    }
}
