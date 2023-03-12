using System;

namespace AddressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("___Welcome to Address book Program___");
            while (true)
            {
                Console.WriteLine("1.Create contact\n2.Add Multiple Contact\n3.Update Contact\n4.Delete contact\n5.Add multiple address book" +
                    "\n6.Add Contact in addressbook\n7.Search person accross city or state\n8.Sort entries by name");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Contact.CreateContact();
                        break;
                    case 2:
                        Contact.AddMultipleContact();
                        break;
                    case 3:
                        Contact.UpdateContact();
                        break;
                    case 4:
                        Contact.DeletePerson();
                        break;
                    case 5:
                        Contact.AddAddressBook();
                        break;
                    case 6:
                        Contact.AddContactInAddressBook();
                        break;
                    case 7:
                        Contact.SearchPersonAcrossCityOrState();
                        break;
                    case 8:
                        Contact.SortEntriesByName();
                        break;
                }
                //Contact.Display();
                Console.WriteLine("________________________");
                Console.ReadLine();
            }
        }
    }
}
    