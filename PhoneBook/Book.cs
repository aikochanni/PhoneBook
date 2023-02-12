using System.Text.RegularExpressions;

namespace PhoneBook
{
    public class Book
    {
        private Dictionary<string, Contact> Contacts = new Dictionary<string, Contact>();

        public Book() { }

        public void AddContact()
        {
            try
            {
                Regex numberValidate = new Regex("^[0-9]{3}-[0-9]{3}-[0-9]{3}$");

                Console.Write("Type name of contact: ");
                
                string inputName = Console.ReadLine();

                Console.Write("Type number of contact [format: 000-000-000]: ");

                string inputNumber = Console.ReadLine();

                if (numberValidate.IsMatch(inputNumber))
                {
                    Contacts.Add(inputName, new Contact(inputName, inputNumber));
                    Console.WriteLine($"Added new contact!");
                }
                else
                {
                    Console.WriteLine("Wrong format number!");
                }
            }
            catch(System.ArgumentException)
            {
                Console.WriteLine("Wrong! Contact with this name exists, cannot be added");
            }

        }
        public void RemoveContact()
        {
            if (Contacts.Count > 0)
            {
                Console.WriteLine("Which contact do you want to remove?");
                Console.Write("Please type: ");

                string inputName = Console.ReadLine();

                Contacts.Remove(inputName);

                Console.WriteLine($"Succesfully removed contact \"{inputName}\" :)");
            }
            else
            {
                Console.WriteLine("Your phonebook is empty. Void cannot be removed");
            }
        }
        public void ShowAllContacts()
        {
            Console.WriteLine("*** CONTACTS ***");

            if (Contacts.Count > 0)
            {
                foreach (KeyValuePair<string, Contact> contact in Contacts)
                {
                    Console.WriteLine($"Name: {contact.Value.GetName()} | Number: {contact.Value.GetNumber()}");
                }
            }
            else
            {
                Console.WriteLine("Your phonebook is empty ;< Are you alone buddy? ;w;");
            }
        }
        public void ShowSelectContact()
        {
            Console.Write("Please enter the name of the contact to be selected: ");

            string inputName = Console.ReadLine();

            if (!string.IsNullOrEmpty(inputName))
            {
                Contact selectedContact = Contacts.FirstOrDefault(e => e.Key == inputName).Value;

                Console.WriteLine("*** SELECTED CONTACT ***");
                Console.WriteLine($"Name: {selectedContact.GetName()} | Number: {selectedContact.GetNumber()}");
            }
            else
            {
                Console.WriteLine("Wrong! Entered contact doesn't exist");
            }
        }
    }
}
