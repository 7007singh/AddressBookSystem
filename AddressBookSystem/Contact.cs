﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AddressBookSystem
{
    internal class Contact
    {
        public static Dictionary<string, List<AddressBookMain>> addressbookDictionary = new Dictionary<string, List<AddressBookMain>>();
        public static List<AddressBookMain> contactList = new List<AddressBookMain>();
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
            contactList.Add(addressBookMain);
        }
        public static void Display()
        {
            foreach (var data in contactList)
            {
                Console.WriteLine("___Displaying contact list___");
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
            Console.WriteLine("Enter first name to edit contact");
            string firstName = Console.ReadLine().ToLower();
            
            foreach(var data in contactList)
            {
                if (contactList.Contains(data))
                {
                    if(data.FirstName.Equals(firstName))
                    {
                        Console.WriteLine("Enter the option to edit\n1:First Name\n2:Last Name\n3:Address\n4:City\n5:State\n6:Zip\n7:Phone number\n8:Email");
                        int editDetail = Convert.ToInt32(Console.ReadLine());
                        switch (editDetail)
                        {
                            case 1:
                                Console.WriteLine("Enter the updated first name");
                                string newFirstName = data.FirstName = Console.ReadLine();
                                break;
                            case 2:
                                Console.WriteLine("Enter the updated last name");
                                string newLastName = data.LastName = Console.ReadLine();
                                break;
                            case 3:
                                Console.WriteLine("Enter the updated address");
                                string newAddress = data.Address = Console.ReadLine();
                                break;
                            case 4:
                                Console.WriteLine("Enter the updated city name");
                                string newCity = data.City = Console.ReadLine();
                                break;
                            case 5:
                                Console.WriteLine("Enter the updated state name");
                                string newState = data.State = Console.ReadLine();
                                break;
                            case 6:
                                Console.WriteLine("Enter the updated zip code");
                                string newZip = data.Zip = Console.ReadLine();
                                break;
                            case 7:
                                Console.WriteLine("Enter the updated phone number");
                                string newPhone = data.PhoneNumber = Console.ReadLine();
                                break;
                            case 8:
                                Console.WriteLine("Enter the updated email id");
                                string newEmail = data.Email = Console.ReadLine();
                                break;
                            case 9:
                                Console.WriteLine("Enter the option from above");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Name does't match.....!!!");
                    }
                }
            } 
        }
        public static void DeletePerson()
        {
            Console.WriteLine("Enter the first name of person to delete");
            string firstName = Console.ReadLine().ToLower();
            for (int i = 0; i < contactList.Count; i++)
            {
                if (contactList[i].FirstName == firstName)
                {
                    Console.WriteLine($"Contact of {contactList[i].FirstName} has been removed");
                    contactList.RemoveAt(i);
                }
            }
        }
        public static void AddMultipleContact()
        {
            Console.WriteLine("Enter the number of contact you want to add");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("--------------------------");
                AddressBookMain addressBookMain = new AddressBookMain();

                Console.WriteLine("Enter first name");
                string firstName = addressBookMain.FirstName = Console.ReadLine();
                Console.WriteLine("Enter last name");
                string lastName = addressBookMain.LastName = Console.ReadLine();
                if (contactList[i].FirstName == addressBookMain.FirstName && contactList[i].LastName == addressBookMain.LastName)
                {
                    Console.WriteLine($"Contact with name: {addressBookMain.FirstName} {addressBookMain.LastName} already exist...\nPlease enter different name");
                }
                else
                {
                    Console.WriteLine("This is valid entry. Proceed further with same...");
                    Console.WriteLine("---------------------------");
                    CreateContact();
                    Console.WriteLine($"{contactList.Count } contacts");
                }
            }
        }
        public static void AddAddressBook()
        {
            AddressBookMain addressBookMain = new AddressBookMain();
            Console.WriteLine("Do you wish to add new Addressbook ? (Y/N):");
            string choice = Console.ReadLine();
            while (choice == "y" || choice == "Y")
            {
                Console.WriteLine("Enter a name for new Address book");
                string name = addressBookMain.AdressbookDictionary = Console.ReadLine();

                if (addressbookDictionary.ContainsKey(name))
                {
                    int i = 1;
                    Console.WriteLine("Name already exist");
                    Console.WriteLine("Available names are: ");
                    foreach (KeyValuePair<string, List<AddressBookMain>> pair in addressbookDictionary)
                    {
                        Console.WriteLine(i + "." + pair.Key + " ");
                        i++;
                    }
                    Console.WriteLine("");
                }
                else
                {
                    addressbookDictionary.Add(name, contactList);
                    Console.WriteLine("AddressBook added successfully");
                }
                Console.WriteLine("Do you wish to add new address book ? (Y/N):");
                choice = Console.ReadLine();
            }
        }
        public static void AddContactInAddressBook()
        {
            if(addressbookDictionary.Count > 0)
            {
                AddressBookMain addressBookMain = new AddressBookMain();
                Console.WriteLine("Do you wish to choose Address Book ?(Y/N):");
                string choice = Console.ReadLine();
                while (choice == "y" || choice == "Y")
                {
                    int i = 1;
                    Console.WriteLine("Enter name of address book you want to use");
                    string name = addressBookMain.AdressbookDictionary = Console.ReadLine();
                    if (addressbookDictionary.ContainsKey(name))
                    {
                        contactList.Add(addressBookMain);
                        Console.WriteLine("Enter first name");
                        string firstName = Console.ReadLine();
                        Console.WriteLine("Enter last name");
                        string lastName = Console.ReadLine();
                        if (contactList[i].FirstName == firstName && contactList[i].LastName == lastName)
                        {
                            Console.WriteLine($"Contact with name: {addressBookMain.FirstName} {addressBookMain.LastName} already exist...\nPlease enter different name");
                        }
                        Console.WriteLine("This is valis entry. Please proceed with same......");
                        CreateContact();
                    }
                    else
                    {
                        Console.WriteLine($"{name} not found \nAvailable names are:");
                        foreach (KeyValuePair<string, List<AddressBookMain>> pair in addressbookDictionary)
                        {
                            Console.WriteLine(i + "." + pair.Key + " ");
                            i++;
                        }
                        Console.WriteLine("");
                    }
                    Console.WriteLine("Do you wish to choose Address Book ?(Y/N):");
                    choice = Console.ReadLine();
                }
            }
        }
    }
}
