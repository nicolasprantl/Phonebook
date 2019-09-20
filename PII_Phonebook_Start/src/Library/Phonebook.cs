using System.Collections.Generic;

namespace Library
{
    public class Phonebook
    {
        private List<Contact> persons;

        public Phonebook(Contact owner)
        {
            this.Owner = owner;
            this.persons = new List<Contact>();
        }

        public Contact Owner { get; }

        public List<Contact> Search(string[] names)
        {
            List<Contact> result = new List<Contact>();

            foreach (Contact person in this.persons)
            {
                foreach (string name in names)
                {
                    if (person.Name.Equals(name))
                    {
                        result.Add(person);
                    }
                }
            }

            return result;
        }

        public void SendTwitter(string[] nombcontactos, string message)
        {
            List<Contact> contactos = Search(nombcontactos);

            foreach (Contact contacto in contactos)
            {
                new MessageTwitter().Send(contacto.Twitter,message);
            }
        }

        public void SendWarap(string[] nombcontactos , string message)
        {
            List<Contact> contactos = Search(nombcontactos);

            foreach (Contact contacto in contactos)
            {
                new MessageWhatsapp().Send(contacto.Phone, message);
            }
        }
    }
}