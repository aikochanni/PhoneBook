using PhoneBook;

Book test = new Book();
string inputName = "";
string inputNumber = "";

ConsoleKeyInfo userInput;

do
{
    Console.Clear();

    Console.WriteLine("What do you want mate?");
    Console.WriteLine("[1] - Add contact");
    Console.WriteLine("[2] - Remove contact");
    Console.WriteLine("[3] - Show all");
    Console.WriteLine("[4] - Show select contact");
    Console.WriteLine("[E] - Exit");
    Console.WriteLine("========================================================================");

    userInput = Console.ReadKey(true);

    switch (userInput.Key)
    {
        case ConsoleKey.D1:
            Console.Write("Type name of contact: ");
            inputName = Console.ReadLine();
            Console.Write("Type number of contact [format: 000-000-000]: ");
            inputNumber = Console.ReadLine();
            test.AddContact(inputName, inputNumber);
            break;
        case ConsoleKey.D2:
            Console.WriteLine("Which contact do you want to remove?");
            Console.Write("Please type: ");
            inputName = Console.ReadLine();
            test.RemoveContact(inputName);
            break;
        case ConsoleKey.D3:
            test.ShowAllContacts();
            break;
        case ConsoleKey.D4:
            Console.Write("Please enter the name of the contact to be selected: ");
            inputName = Console.ReadLine();
            test.ShowSelectContact(inputName);
            break;
        case ConsoleKey.E:
            return;
    }

    Console.WriteLine("========================================================================");
    Console.WriteLine("[Enter] - to continue");
    Console.WriteLine("[E] - to exit");

    userInput = Console.ReadKey(true);

    switch (userInput.Key)
    {
        case ConsoleKey.Enter:
            break;
        case ConsoleKey.E:
            return;
    }

} while (userInput.Key != ConsoleKey.E);

