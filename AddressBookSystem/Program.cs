using System;

namespace AddressBookSystem
{
    internal class Program
    {        
        static void Main(string[] args)
        {
            Console.WriteLine("___Welcome to Address book Program___");

            Console.WriteLine("1:Add contact\n2:Update contact");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    Contact.CreateContact();
                    Contact.Display();
                    Console.ReadLine();
                    break;
                case "2":
                    Contact.CreateContact();
                    Contact.UpdateContact();
                    Console.ReadLine();
                    break;
            }
            Console.ReadLine();
        }
    }
}
    