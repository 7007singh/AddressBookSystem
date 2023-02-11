using System;
using System.CodeDom;
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
                                string newFirstName = data.FirstName = Console.ReadLine();
                                Console.WriteLine("Updated first name is " + newFirstName);
                                break;
                            case 2:
                                Console.WriteLine("Enter the new last name");
                                string newLastName = data.FirstName = Console.ReadLine();
                                Console.WriteLine("Updated last name " + newLastName);
                                break;
                            case 3:
                                Console.WriteLine("Enter the new address");
                                string newAddress = data.Address = Console.ReadLine();
                                Console.WriteLine("Updated address is " + newAddress);
                                break;
                            case 4:
                                Console.WriteLine("Enter the new city name");
                                string newCity = data.City = Console.ReadLine();
                                Console.WriteLine("Updated city" + newCity);
                                break;
                            case 5:
                                Console.WriteLine("Enter the new state name");
                                string newState = data.State = Console.ReadLine();
                                Console.WriteLine("Updated state " + newState);
                                break;
                            case 6:
                                Console.WriteLine("Enter the new zip code");
                                string newZip = data.Zip = Console.ReadLine();
                                Console.WriteLine("Updated zip code " + newZip);
                                break;
                            case 7:
                                Console.WriteLine("Enter the new phone number");
                                string newPhone = data.PhoneNumber = Console.ReadLine();
                                Console.WriteLine("Updated phone number " + newPhone);
                                break;
                            case 8:
                                Console.WriteLine("Enter the new email id");
                                string newEmail = data.Email = Console.ReadLine();
                                Console.WriteLine("Updated email " + newEmail);
                                break;
                            case 9:
                                Console.WriteLine("Enter the option from above");
                                break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Contact not exist");
                }
            } 
        }
        public static void DeletePerson()
        {
            Console.WriteLine("Enter the first name of person to delete");
            string firstName = Console.ReadLine().ToLower();
            for (int i = 0; i < contact.Count; i++)
            {
                if (contact[i].FirstName == firstName)
                {
                    contact.RemoveAt(i);
                    Console.WriteLine("Contact has been removed");
                }
            }
        }
        public static void AddMultipleContact()
        {
            Console.WriteLine("Enter the number of contact you want to add");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {   
                Console.WriteLine("--------------------------");
                AddressBookMain addressBookMain = new AddressBookMain();
  
                Console.WriteLine("Enter first name");
                string firstName = addressBookMain.FirstName = Console.ReadLine();
                Console.WriteLine("Enter last name");
                string lastName = addressBookMain.LastName = Console.ReadLine();
                if (contact[i].FirstName == addressBookMain.FirstName && contact[i].LastName == addressBookMain.LastName)
                {
                    Console.WriteLine($"Contact with name: {addressBookMain.FirstName} {addressBookMain.LastName} already exist...\nPlease enter different name");
                }
                else
                {
                    Console.WriteLine("This is valid entry. Proceed further with same...");
                    Console.WriteLine("---------------------------");
                    CreateContact();
                    Console.WriteLine($"{contact.Count + 1} contacts");
                }
            }
        }
    }
}
