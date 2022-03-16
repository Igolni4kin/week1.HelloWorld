using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is you first name?");
            string userFirstName =Console.ReadLine();
            Console.WriteLine("what is your last name");
            string userLastName = Console.ReadLine();
            Console.WriteLine("Hello, " + userFirstName +" " + userLastName + "!");


        }


    }
}
