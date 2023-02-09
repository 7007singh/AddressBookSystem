using System;

namespace AddressBookSystem
{
    internal class Program
    {        
        static void Main(string[] args)
        {
            Console.WriteLine("___Welcome to Address book Program___");

            Contact.CreateContact();
            Contact.Display();
            Console.ReadLine();
        }
    }
}
