using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Contact
    {
        private string Name;
        private string Number;

        public Contact(string name, string number)
        {
            Name = name;
            Number = number;
        }

        public string GetName()
        {
            return Name;
        }

        public string GetNumber()
        {
            return Number;
        }
    }
}
