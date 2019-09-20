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

            var pedrito = new Contact("pedrito");
            
            
            // Crear la lista de contactos
            var telefonera = new Phonebook(nicolas);
            // Agregar contactos a la lista

            // Enviar un correo a algunos contactos

            // Enviar un WhatsApp a algunos contactos
            
            
            //telefonera.SendWarap();
            //telefonera.SendTwitter();
            
            //MessageWhatsapp.Send("nicolas","Hoaaaa");
            
            // Enviar un SMS a algunos contactos
            
            //MessageTwitter.Send("nicolas","Hoaaa");
        }
    }
}
