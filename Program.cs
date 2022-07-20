namespace AddressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");

            CreateContact createContact = new CreateContact();

            string command = "";
            while (command != "exit")
            {
                Console.Clear();
                Console.WriteLine("Enter \'add\' to Add a Person, Enter \'list\' to list the Persons in the AddressBook: ");
                command = Console.ReadLine().ToLower();
                switch (command)
                {
                    case "add":
                        createContact.AddPerson();
                        break;
                    case "list":
                        createContact.ListPeople();
                        break;
                }

                Console.WriteLine("Enter \'exit\' to exit the AddressBook or \'1\' to continue");
                command=Console.ReadLine();
            }
        }
        
    }
}