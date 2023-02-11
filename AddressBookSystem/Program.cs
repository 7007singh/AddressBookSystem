using System;
using System.Collections.Generic;

namespace AddressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("___Welcome to Address book Program___");

            Contact.CreateContact();
            Contact.AddMultipleContact();
            Contact.UpdateContact();
            Contact.DeletePerson();   
            Contact.Display();
            Console.ReadLine();
        }
    }
}
    