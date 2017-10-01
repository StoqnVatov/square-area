using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var firstname = Console.ReadLine();
            var lastname = Console.ReadLine();
            var age = Console.ReadLine();
            var town = Console.ReadLine();
            Console.Write("You are " );
            Console.Write(firstname );
            Console.Write(" ");
            Console.Write(lastname);
            Console.Write(", a ");
            Console.Write(age);
            Console.Write("-years old person from ");
            Console.Write(town);
            Console.WriteLine(".");
        }
    }
}
