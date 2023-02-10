﻿using System;
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
        public static void UpdateContact()
        {
            AddressBookMain addressBookMain = new AddressBookMain();
            Console.WriteLine("Enter first name to edit contact");
            string firstName = Console.ReadLine().ToLower();
            
            foreach(var data in contact)
            {
                if (contact.Contains(data))
                {
                    if(data.FirstName.Equals(firstName))
                    {
                        Console.WriteLine("Enter the option to edit\n1:First Name\n2:Last Name\n3:Address\n4:City\n5:State\n6:Zip\n7:Phone number\n8:Email");
                        int editDetail = Convert.ToInt32(Console.ReadLine());
                        switch (editDetail)
                        {
                            case 1:
                                Console.WriteLine("Enter the new first name");
                                string newFirstName = addressBookMain.FirstName = Console.ReadLine();
                                Console.WriteLine("Updated first name is " + newFirstName);
                                break;
                            case 2:
                                Console.WriteLine("Enter the new last name");
                                string newLastName = addressBookMain.FirstName = Console.ReadLine();
                                Console.WriteLine("Updated last name " + newLastName);
                                break;
                            case 3:
                                Console.WriteLine("Enter the new address");
                                string newAddress = addressBookMain.Address = Console.ReadLine();
                                Console.WriteLine("Updated address is " + newAddress);
                                break;
                            case 4:
                                Console.WriteLine("Enter the new city name");
                                string newCity = addressBookMain.City = Console.ReadLine();
                                Console.WriteLine("Updated city" + newCity);
                                break;
                            case 5:
                                Console.WriteLine("Enter the new state name");
                                string newState = addressBookMain.State = Console.ReadLine();
                                Console.WriteLine("Updated state " + newState);
                                break;
                            case 6:
                                Console.WriteLine("Enter the new zip code");
                                string newZip = addressBookMain.Zip = Console.ReadLine();
                                Console.WriteLine("Updated zip code " + newZip);
                                break;
                            case 7:
                                Console.WriteLine("Enter the new phone number");
                                string newPhone = addressBookMain.PhoneNumber = Console.ReadLine();
                                Console.WriteLine("Updated phone number " + newPhone);
                                break;
                            case 8:
                                Console.WriteLine("Enter the new email id");
                                string newEmail = addressBookMain.Email = Console.ReadLine();
                                Console.WriteLine("Updated email " + newEmail);
                                break;
                            case 9:
                                Console.WriteLine("Enter the option from above");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Contact does't exist");
                    }
                }
            } 
        }
    }
}