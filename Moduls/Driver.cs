using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace TransRiwi.Moduls
{
    public class Driver : User
    {

        public string? LisenceNumber {get; set;}
        public string? LisenceCategory {get;set;}
        public int DrivingExperience {get; set;}
        public Driver(string? lisenceNumber, string? lisenceCategory, int drivingExperience, Guid id, string name, string lastName, string typeDocument, string identificationNumber, DateOnly birthDate, string email, string phoneNumber) : 
        base (id, name, lastName, typeDocument, identificationNumber, birthDate, email, phoneNumber)
        {
            LisenceNumber = lisenceNumber;
            LisenceCategory = lisenceCategory;
            DrivingExperience = drivingExperience;
            Id = id;
            Name = name;
            LastName = lastName;
            TypeDocument = typeDocument;
            IdentificationNumber = identificationNumber;
            BirthDate = birthDate;
            Email = email;
            PhoneNumber = phoneNumber;

        }

        public void UpdateLisenceCategory(string newCategory)
        {

        }

        public void AddExperience(int years)
        {

        }
        
    }
}