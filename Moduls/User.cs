using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransRiwi.Moduls
{
    public class User
    {

        public Guid Id {get; set;}
        public string Name {get; set;}
        public string LastName {get; set;}
        public string TypeDocument {get; set;}
        public string IdentificationNumber {get; set;}
        public DateOnly BirthDate {get; set;}
        public string Email {get; set;}
        public string PhoneNumber {get; set;}
        public User(Guid id, string name, string lastName, string typeDocument, string identificationNumber, DateOnly birthDate, string email, string phoneNumber)
        {
            Id = id;
            Name = name;
            LastName = lastName;
            TypeDocument = typeDocument;
            IdentificationNumber = identificationNumber;
            BirthDate = birthDate;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        public void ShowDetails()
        {
            Console.WriteLine("Mostrando la informacion del usuario: ");
            Console.WriteLine($"ID = {Id}");
            Console.WriteLine($"");
            Console.WriteLine($"");
            Console.WriteLine($"");
            Console.WriteLine($"");
            Console.WriteLine($"");
            Console.WriteLine($"");
            Console.WriteLine($"");
        }

        public int CalculateAge()
        {
            var fechaActual = DateTime.Now.Year;
            var edad = fechaActual - BirthDate.Year;
            return  edad;

        }

        public void ShowAge()
        {
            Console.WriteLine($"La edad del usuario es: {CalculateAge}");
        }

    
    }
}