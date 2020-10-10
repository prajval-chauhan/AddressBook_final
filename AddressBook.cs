using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace AddressBook_final
{
    class AddressBook
    {
        public static List<AddressBook> Records = new List<AddressBook>();
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string MobileNumber { get; set; }
        public string eMail { get; set; }
        public string address { get; set; }
        public string zipCode { get; set; }
        public string state { get; set; }

        public void AddContact()
        {
            Console.Clear();
            AddressBook contact = new AddressBook();
            Console.WriteLine("Enter the first name of the person: ");
            contact.firstName = Console.ReadLine();
            Console.WriteLine("Enter the last name of the person: ");
            contact.lastName = Console.ReadLine();
            Console.WriteLine("Enter the mobile number of the person: ");
            contact.MobileNumber = Console.ReadLine();
            Console.WriteLine("Enter the email ID of the person: ");
            contact.eMail = Console.ReadLine();
            Console.WriteLine("Enter the address of the person");
            contact.address = Console.ReadLine();
            Console.WriteLine("Enter the ZIP code: ");
            contact.zipCode = Console.ReadLine();
            Console.WriteLine("Enter the state: ");
            contact.state = Console.ReadLine();
            Console.Clear();
            Records.Add(contact);
        }
        public void DisplayContact(AddressBook contact)
        {
            Console.WriteLine("First Name : " + contact.firstName);
            Console.WriteLine("Last Name : " + contact.lastName);
            Console.WriteLine("Mobile  Number : " + contact.MobileNumber);
            Console.WriteLine("Email : " + contact.eMail);
            Console.WriteLine("Address : " + contact.address);
            Console.WriteLine("ZIP Code: " + contact.zipCode);
            Console.WriteLine("state : " + contact.state);
            Console.WriteLine("***************");
        }

        public void DisplayRecords()
        {
            Console.Clear();
            if (Records.Count == 0)
            {
                Console.WriteLine("The address book has no entries");
            }
            else
            {
                Console.WriteLine("***Your Contacts***\n\n***************");
                foreach(var contact in Records)
                {
                    DisplayContact(contact);
                }
            }
            Console.ReadKey();
            Console.Clear();
        }


    }
}
