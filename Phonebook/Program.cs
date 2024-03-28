using Phonebook;
using System.Threading.Channels;

Console.WriteLine("Hello from the Console PhoneBook app");
Console.WriteLine("Select operation");
Console.WriteLine("1 Add contact");
Console.WriteLine("2 Display contact by number");
Console.WriteLine("3 View all contacts");
Console.WriteLine("4 Search for contacts for a given name");
Console.WriteLine("Press 'x' to exit");

var userInput = Console.ReadLine();

var phoneList = new PhoneList();

while (true)
{
    switch (userInput)
    {
        case "1":
            Console.WriteLine("Contact name:");
            var name = Console.ReadLine();

            Console.WriteLine("Contact number");
            var number = Console.ReadLine();

            var newContact = new Contact(name, number);
            phoneList.AddContact(newContact);

            break;

        case "2":
            Console.WriteLine("Contact number to search");
            var searchNumber = Console.ReadLine();
            phoneList.DisplayContact(searchNumber);
            break;
        case "3":
            phoneList.DisplayAllContacts();
            break;
        case "4":
            Console.WriteLine("Name search phrase");
            var searchPhrase = Console.ReadLine();
            phoneList.DisplayMatchingContacts(searchPhrase);
            break;
        case "x":
            return;
        default:
            Console.WriteLine("Select valid operation");
            break;
    }
    Console.WriteLine("Select operation");
    userInput = Console.ReadLine();
}




