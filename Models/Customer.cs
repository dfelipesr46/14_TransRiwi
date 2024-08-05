using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransRiwi.Moduls
{
    public class Customer : User
    {

        public string? MembershipLevel {get; set;}
        public string? PreferredPaymentMethod {get; set;}
        public Customer(string? membershipLevel, string? preferredPaymentMethod, string name, string lastName, string typeDocument, string identificationNumber, DateOnly birthDate, string email, string phoneNumber) : 
        base (name, lastName, typeDocument, identificationNumber, birthDate, email, phoneNumber)
        {
            MembershipLevel = membershipLevel;
            PreferredPaymentMethod = preferredPaymentMethod;
            Name = name;
            LastName = lastName;
            TypeDocument = typeDocument;
            IdentificationNumber = identificationNumber;
            BirthDate = birthDate;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        public void UpdateMembershipLevel()
        {

        }


    }
}