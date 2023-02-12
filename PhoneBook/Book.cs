using System.Text.RegularExpressions;

namespace PhoneBook
{
    public class Book
    {
        private Dictionary<string, Contact> Contacts = new Dictionary<string, Contact>();

        public Book() { }

        public void AddContact(string inputName, string inputNumber)
        {
            try
            {
                Regex numberValidate = new Regex("^[0-9]{3}-[0-9]{3}-[0-9]{3}$");

                if (numberValidate.IsMatch(inputNumber))
                {
                    Contacts.Add(inputNumber, new Contact(inputName, inputNumber));
                    Console.WriteLine($"Added new contact!");
                }
                else
                {
                    Console.WriteLine("Wrong format number!");
                }
            }
            catch(System.ArgumentException)
            {
                Console.WriteLine("Wrong! Contact with this number exists, cannot be added");
            }

        }
        public void RemoveContact(string inputNumber)
        {
            if (Contacts.Count > 0)
            {
                Contacts.Remove(inputNumber);

                Console.WriteLine($"Succesfully removed contact \"{inputNumber}\" :)");
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
        public void ShowSelectContact(string inputName)
        {
            if (!string.IsNullOrEmpty(inputName))
            {
                List<Contact> selectedContact = Contacts.Where(e => e.Value.GetName() == inputName).Select(e => e.Value).ToList();

                Console.WriteLine("*** SELECTED CONTACTS ***");
                foreach (Contact contact in selectedContact)
                {
                    Console.WriteLine($"Name: {contact.GetName()} | Number: {contact.GetNumber()}");
                }
            }
            else
            {
                Console.WriteLine("Wrong! Entered contact doesn't exist");
            }
        }
    }
}
