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
        public byte PeopleCapacity {get; set;}
        public string? Owner {get; set;}
        public Vehicle( string? placa, string? tipo, string? engineNumber, string? serialNumber, byte peopleCapacity, string? owner)
        {
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

        public void showVehicles()
        {
            Console.WriteLine($"La placa del Vehiculo {Placa}");
            Console.WriteLine($"Tipo de Vehiculo {Tipo}");
            Console.WriteLine($"Numero de motor {EngineNumber}");
            Console.WriteLine($"Numero de serie {SerialNumber}");
            Console.WriteLine($"El vehiculo cuenta con capacidad para {PeopleCapacity} pasajeros");
        }

    }
}