using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class Contact
    {
        public static List<AddressBookMain> contact = new List<AddressBookMain>();
        public static void CreateContact()
        {
            AddressBookMain addressBookMain = new AddressBookMain();

            Console.WriteLine("Enter first name");
            addressBookMain.FirstName = Console.ReadLine();
            Console.WriteLine("Enter last name");
            addressBookMain.LastName = Console.ReadLine();
            Console.WriteLine("Enter Address");
            addressBookMain.Address = Console.ReadLine();
            Console.WriteLine("Enter City");
            addressBookMain.City = Console.ReadLine();
            Console.WriteLine("Enter State");
            addressBookMain.State = Console.ReadLine();
            Console.WriteLine("Enter Zip code");
            addressBookMain.Zip = Console.ReadLine();
            Console.WriteLine("Enter Phone number");
            addressBookMain.PhoneNumber = Console.ReadLine();
            Console.WriteLine("Enter Email");
            addressBookMain.Email = Console.ReadLine();

            contact.Add(addressBookMain);
            Console.ReadLine();
        }

        public static void Display()
        {
            foreach (var data in contact)
            {
                Console.WriteLine("First name:" + data.FirstName);
                Console.WriteLine("Last name: " + data.LastName);
                Console.WriteLine("Address: " + data.Address);
                Console.WriteLine("City: " + data.City);
                Console.WriteLine("State: " + data.State);
                Console.WriteLine("Zip Code: " + data.Zip);
                Console.WriteLine("Phone no.: " + data.PhoneNumber);
                Console.WriteLine("Email Address: " + data.Email);
            }
        }
    }
}