using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear el contacto dueño
            var nicolas = new Contact("nicolas");
            nicolas.Phone = "+59899000779";
            nicolas.Twitter = "2354094344";
            nicolas.Email = "nointeresa";
            
            
            // Crear la lista de contactos
            var phonebook = new Phonebook(nicolas);
            // Agregar contactos a la lista
            phonebook.AddContact("Maria", "123456789", "maria");
            phonebook.AddContact("Rodrigo", "987654321", "rodri");
            phonebook.AddContact("Facundo", "741852963", "facu");

            // Enviar un WhatsApp a algunos contactos
            MessageWhatsapp whatsapp = new MessageWhatsapp();
            whatsapp.Send(nicolas.Phone,"Hoaaaa");
            
            // Enviar un Tweet a algunos contactos
            MessageTwitter twitter = new MessageTwitter();
            twitter.Send(nicolas.Twitter, "Hello world");
        }
    }
}
