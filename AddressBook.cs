using System;
using System.Collections.Generic;
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

            Records.Add(contact);
        }



        
    }
}
