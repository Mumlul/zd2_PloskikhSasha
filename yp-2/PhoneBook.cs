using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace yp_2
{
    internal class PhoneBook
    {
        private List<Contact> contacts = new List<Contact>();

        public void AddContact(Contact contact)
        {
            contacts.Add(contact);
        }
        public void AddContact(string name,string contact)
        {
            Contact ss = new Contact(name, contact);
            contacts.Add(ss);
        }

        public void RemoveContact(string name)
        {
            contacts.RemoveAll(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public Contact FindContact(string name)
        {
            return contacts.FirstOrDefault(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public List<Contact> GetAllContacts()
        {
            return contacts;
        }

        public bool EditContact(string oldName, string newName, string newContact)
        {
            
            Contact contactToEdit = FindContact(oldName);
            if (contactToEdit != null)
            {
                contactToEdit.Name = newName;
                contactToEdit.Phone = newContact; 
                return true; 
            }
            return false; 
        }
    }
}
