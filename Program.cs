using System;

namespace AddressBook_final
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Welcome to the Address Book Program ***\n");

            AddressBook call = new AddressBook();

            for (; ; )
            {
                Console.WriteLine("Enter 1 to Add Contact\nEnter 2 to display contacts\nEnter 3 to exit\n");
                int userInput = Convert.ToInt32(Console.ReadLine());
                switch (userInput)
                {
                    case 1:
                        call.AddContact();
                        break;
                    case 2:
                        call.DisplayRecords();
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                            break;
                }
                if (userInput == 3)
                    break;
            }
            
        }
    }
}
