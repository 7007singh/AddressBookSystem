using System;

namespace AddressBookSystem
{
    internal class Program
    {        
        static void Main(string[] args)
        {
            Console.WriteLine("___Welcome to Address book Program___");

            Console.WriteLine("Choose the option from below\n1:Add contact\n2:Update contact\n3:Delete Contact");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    Contact.CreateContact();
                    Contact.Display();
                    Console.ReadLine();
                    break;
                case "2":
                    //Contact.CreateContact();
                    Contact.UpdateContact();
                    Console.ReadLine();
                    break;
                case "3":
                    Contact.DeletePerson();
                    Console.ReadLine();
                    break;
            }
            Console.ReadLine();
        }
    }
}
    