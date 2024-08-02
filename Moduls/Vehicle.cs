using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransRiwi.Moduls
{
    public class Vehicle
    {

        public int Id {get; set;}
        public string? Placa {get; set;}
        public string? Tipo {get; set;}
        public string? EngineNumber {get; set;}
        public string? SerialNumber {get; set;}
        public string? PeopleCapacity {get; set;}
        public string? Owner {get; set;}
        public Vehicle(int id, string? placa, string? tipo, string? engineNumber, string? serialNumber, string? peopleCapacity, string? owner)
        {
            Id = id;
            Placa = placa;
            Tipo = tipo;
            EngineNumber = engineNumber;
            SerialNumber = serialNumber;
            PeopleCapacity = peopleCapacity;
            Owner = owner;
        }

        public void DeleteVehicle(int id)
        {

        }

        

    }
}