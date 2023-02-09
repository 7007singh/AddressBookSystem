using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class Contact
    {
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
        }
    }
}