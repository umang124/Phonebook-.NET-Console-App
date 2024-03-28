using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    public class PhoneList
    {
        private List<Contact> _contacts { get; set; }

        public PhoneList()
        {
            _contacts = new List<Contact>();
        }

        public void AddContact(Contact contact)
        {
            _contacts.Add(contact);
        }

        public void DisplayContact(string number)
        {
            var contact = _contacts.FirstOrDefault(x => x.Number == number);
            if (contact == null)
            {
                Console.WriteLine("Contact not found");
            }
            else
            {
                Console.WriteLine("Contact: " + contact.Name + " " + contact.Number);
            }
        }

        public void DisplayAllContacts()
        {
            foreach(var contact in _contacts)
            {
                Console.WriteLine("Contact: " + contact.Name + " " + contact.Number);
            }
        }

        public void DisplayMatchingContacts(string searchPhrase)
        {
            var matchingContacts = _contacts.Where(x => x.Name.Contains(searchPhrase)).ToList();

            foreach(var contact in matchingContacts)
            {
                Console.WriteLine("Contact: " + contact.Name + " " + contact.Number);
            }
        }
    }
}
