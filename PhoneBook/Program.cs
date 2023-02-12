using PhoneBook;

Book test = new Book();

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
            test.AddContact();
            break;
        case ConsoleKey.D2:
            test.RemoveContact();
            break;
        case ConsoleKey.D3:
            test.ShowAllContacts();
            break;
        case ConsoleKey.D4:
            test.ShowSelectContact();
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

