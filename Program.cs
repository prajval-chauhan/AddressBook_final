using System;

namespace AddressBook_final
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Welcome to the Address Book Program ***\n");
            Console.WriteLine("Enter 1 to Add Contact\nEnter 2 to display contacts\nEnter 3 to exit\n");
            AddressBook call = new AddressBook();
            call.AddContact();
        }
    }
}
