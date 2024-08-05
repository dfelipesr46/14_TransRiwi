using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransRiwi.Moduls
{
    public class Admin
    {

        public List<Driver> DriverList { get; set; } = new List<Driver>();
        public List<Customer> CustomerList { get; set; } = new List<Customer>();
        public List<Vehicle> VehicleList { get; set; } = new List<Vehicle>();
        
        // CRUD PARA CONDUCTORES
        public void AddDriver()
        {
            Console.WriteLine("Para crear un nuevo conductor porfavor ingrese lo siguientes datos: ");

            Console.WriteLine("Nombre: ");
            string? name = Console.ReadLine();

            Console.WriteLine("Apellido: ");
            string? lastName = Console.ReadLine();

            Console.WriteLine("Tipo de documento: ");
            string? idType = Console.ReadLine();

            Console.WriteLine("Número de documento: ");
            string? idNumber = Console.ReadLine();

            Console.WriteLine("Fecha de nacimiento: ");
            DateOnly birthDate = DateOnly.Parse(Console.ReadLine());
            // if (birthDate != null)
            // {
            //     DateOnly fecha = DateOnly.Parse(birthDate);
            // }
            // else
            // {
            //     Console.WriteLine("La fecha ingresada es nula o no válida.");
            // }



            Console.WriteLine("Correo electrónico: ");
            string? email = Console.ReadLine();

            Console.WriteLine("Número de telefono: ");
            string? phoneNumber = Console.ReadLine();

            Console.WriteLine("Número de lisencia: ");
            string? lisenceNumber = Console.ReadLine();

            Console.WriteLine("Que categoria es la licencia? ");
            Console.WriteLine("A2 ");
            Console.WriteLine("B2 ");
            string? licenseCategory = Console.ReadLine();
            if (licenseCategory != null)
            {
                licenseCategory = licenseCategory.ToUpper();
                if (licenseCategory == "A2" && licenseCategory == "B2")
                {
                    Console.WriteLine("Categoria correcta");
                }
                else
                {
                    Console.WriteLine("Categoria incorrecta, escriba A2 o B2 según corresponda");
                }
            }
            else
            {
                Console.WriteLine("ingrese A2 o B2");
            }

            Console.WriteLine("Cuanto años de experiencia tienes conduciendo? ");
            int drivingExperience = int.Parse(Console.ReadLine());

            Driver newDriver = new Driver(lisenceNumber, licenseCategory, drivingExperience, name, lastName, idType, idNumber, birthDate, email, phoneNumber);
            DriverList.Add(newDriver);

            Console.WriteLine("Conductor agregado con exito");
        }

        public void ShowDrivers()
        {
            Console.WriteLine("Mostrando los conductores incritos: ");
            foreach (var drivers in DriverList)
            {
                Console.WriteLine($"Imprimiendo la lista de Conductores {drivers}");
            }
        }

        public void DriverUpdate()
        {
            Console.WriteLine("Ingrese el numero de cedula del Conductor: ");
            string? cedulaConductor = Console.ReadLine();

            if (!string.IsNullOrEmpty(cedulaConductor))
            {
                Driver? driver = DriverList.Find(c => c.IdentificationNumber == cedulaConductor);

                if (driver != null)
                {
                    Console.WriteLine("Conductor encontrado, porfavor ingrese los datos que desea actualizar");

                    Console.WriteLine($"Presione enter para mantener el actual ", driver.Name);
                    string? newName = Console.ReadLine();
                    if (newName != null)
                    {
                        driver.Name = newName;
                    }

                    Console.WriteLine($"Presione enter para mantener el actual ", driver.LastName);
                    string? newLastName = Console.ReadLine();
                    if (newLastName != null)
                    {
                        driver.LastName = newLastName;
                    }

                    Console.WriteLine($"Presione enter para mantener el actual ", driver.TypeDocument);
                    string? newTypeDocument = Console.ReadLine();
                    if (newTypeDocument != null)
                    {
                        driver.TypeDocument = newTypeDocument;
                    }

                    Console.WriteLine($"Presione enter para mantener el actual ", driver.IdentificationNumber);
                    string? newIdNumber = Console.ReadLine();
                    if (newIdNumber != null)
                    {
                        driver.IdentificationNumber = newIdNumber;
                    }

                    Console.WriteLine($"Presione enter para mantener el actual ", driver.BirthDate);
                    DateOnly newBirthDay = DateOnly.Parse(Console.ReadLine());
                    if (newBirthDay != null)
                    {
                        driver.BirthDate = newBirthDay;
                    }

                    Console.WriteLine($"Presione enter para mantener el actual ", driver.Email);
                    string? newEmail = Console.ReadLine();
                    if (newEmail != null)
                    {
                        driver.Email = newEmail;
                    }

                    Console.WriteLine($"Presione enter para mantener el actual ", driver.PhoneNumber);
                    string? newPhoneNumber = Console.ReadLine();
                    if (newPhoneNumber != null)
                    {
                        driver.PhoneNumber = newPhoneNumber;
                    }

                    Console.WriteLine("Datos actualizados con éxito");
                }
                else
                {
                    Console.WriteLine("Conductor no encontrado");
                }
            }
            else
            {
                Console.WriteLine("Número de cedula invalido");
            }
        }

        public void DriverDelete()
        {
            Console.WriteLine("Ingrese el numero de documento del Conductor que desea eliminar: ");
            string? driverDelete = Console.ReadLine();

            if (driverDelete != null)
            {
                Driver delete = DriverList.Find(d => d.IdentificationNumber == driverDelete);
                if (delete != null)
                {
                    DriverList.Remove(delete);
                    Console.WriteLine("El conductor ha sido eliminado");
                }
                else
                {
                    Console.WriteLine("El conductor no ha sido encontrado");
                }
            }
            else
            {
                Console.WriteLine("Número de documento invalido ");
            }
        }

        // CRUD PARA CLIENTES
        public void AddCustomer()
        {
            Console.WriteLine("Para crear un nuevo conductor porfavor ingrese lo siguientes datos: ");

            Console.WriteLine("Nombre: ");
            string? name = Console.ReadLine();

            Console.WriteLine("Apellido: ");
            string? lastName = Console.ReadLine();

            Console.WriteLine("Tipo de documento: ");
            string? idType = Console.ReadLine();

            Console.WriteLine("Número de documento: ");
            string? idNumber = Console.ReadLine();

            Console.WriteLine("Fecha de nacimiento: ");
            DateOnly birthDate = DateOnly.Parse(Console.ReadLine());

            Console.WriteLine("Correo electrónico: ");
            string? email = Console.ReadLine();

            Console.WriteLine("Número de telefono: ");
            string? phoneNumber = Console.ReadLine();

            Console.WriteLine("Escoja el tipo de membresía");
            Console.WriteLine("Basic");
            Console.WriteLine("Premium");
            string? membershipLevel = Console.ReadLine();
            if (membershipLevel != null)
            {
                membershipLevel = membershipLevel.ToLower();
                if (membershipLevel == "basic" || membershipLevel == "premium")
                {
                    Console.WriteLine("Categoria correcta");
                }
                else
                {
                    Console.WriteLine("Categoria incorrecta, escriba basic o premium según corresponda");
                }
            }
            else
            {
                Console.WriteLine("Ingrese Basic o Premium");
            }

            Console.WriteLine("Escoja el metodo de pago");
            Console.WriteLine("Credit Card");
            Console.WriteLine("Cash");
            string? paymethod = Console.ReadLine();
            if (paymethod != null)
            {
                paymethod = paymethod.ToUpper();
                if (paymethod == "credit card" || paymethod == "cash")
                {
                    Console.WriteLine("Metodo de pago agregado");
                }
                else
                {
                    Console.WriteLine("Categoria incorrecta, escriba 'Credit card' o 'Cash' según corresponda");
                }
            }
            else
            {
                Console.WriteLine("ingrese 'Credit Card' o 'Cash'");
            }

            Customer newCustomer = new Customer(membershipLevel, paymethod, name, lastName, idType, idNumber, birthDate, email, phoneNumber);
            CustomerList.Add(newCustomer);

            Console.WriteLine("Cliente agregado con exito");
        }

        public void ShowCustomers()
        {
            Console.WriteLine("Mostrando los clientes incritos: ");
            foreach (var customers in CustomerList)
            {
                Console.WriteLine($"Imprimiendo la lista de Conductores {customers}");
            }
        }

        public void CustomerUpdate()
        {
            Console.WriteLine("Ingrese el numero de cedula del Cliente: ");
            string? cedulaCliente = Console.ReadLine();

            if (!string.IsNullOrEmpty(cedulaCliente))
            {
                Customer? customer = CustomerList.Find(c => c.IdentificationNumber == cedulaCliente);

                if (customer != null)
                {
                    Console.WriteLine("Cliente encontrado, porfavor ingrese los datos que desea actualizar");

                    Console.WriteLine($"Presione enter para mantener el actual ", customer.Name);
                    string? newName = Console.ReadLine();
                    if (newName != null)
                    {
                        customer.Name = newName;
                    }

                    Console.WriteLine($"Presione enter para mantener el actual ", customer.LastName);
                    string? newLastName = Console.ReadLine();
                    if (newLastName != null)
                    {
                        customer.LastName = newLastName;
                    }

                    Console.WriteLine($"Presione enter para mantener el actual ", customer.TypeDocument);
                    string? newTypeDocument = Console.ReadLine();
                    if (newTypeDocument != null)
                    {
                        customer.TypeDocument = newTypeDocument;
                    }

                    Console.WriteLine($"Presione enter para mantener el actual ", customer.IdentificationNumber);
                    string? newIdNumber = Console.ReadLine();
                    if (newIdNumber != null)
                    {
                        customer.IdentificationNumber = newIdNumber;
                    }

                    Console.WriteLine($"Presione enter para mantener el actual ", customer.BirthDate);
                    DateOnly newBirthDay = DateOnly.Parse(Console.ReadLine());
                    if (newBirthDay != null)
                    {
                        customer.BirthDate = newBirthDay;
                    }

                    Console.WriteLine($"Presione enter para mantener el actual ", customer.Email);
                    string? newEmail = Console.ReadLine();
                    if (newEmail != null)
                    {
                        customer.Email = newEmail;
                    }

                    Console.WriteLine($"Presione enter para mantener el actual ", customer.PhoneNumber);
                    string? newPhoneNumber = Console.ReadLine();
                    if (newPhoneNumber != null)
                    {
                        customer.PhoneNumber = newPhoneNumber;
                    }

                    Console.WriteLine($"Presione enter para mantener el actual ", customer.MembershipLevel);
                    string? newMembershipLevel = Console.ReadLine();
                    if (newMembershipLevel != null)
                    {
                        customer.MembershipLevel = newMembershipLevel;
                    }

                    Console.WriteLine($"Presione enter para mantener el actual ", customer.PreferredPaymentMethod);
                    string? newPayMethod = Console.ReadLine();
                    if (newPayMethod != null)
                    {
                        customer.PreferredPaymentMethod = newPayMethod;
                    }

                    Console.WriteLine("Datos actualizados con éxito");
                }
                else
                {
                    Console.WriteLine("Conductor no encontrado");
                }
            }
            else
            {
                Console.WriteLine("Número de cedula invalido");
            }
        }

        public void CustomerDelete()
        {
            Console.WriteLine("Ingrese el numero de documento del Cliente que desea eliminar: ");
            string? customerDelete = Console.ReadLine();

            if (customerDelete != null)
            {
                Customer delete = CustomerList.Find(d => d.IdentificationNumber == customerDelete);
                if (delete != null)
                {
                    CustomerList.Remove(delete);
                    Console.WriteLine("El cliente ha sido eliminado");
                }
                else
                {
                    Console.WriteLine("El cliente no ha sido encontrado");
                }
            }
            else
            {
                Console.WriteLine("Número de documento invalido ");
            }
        }


        // CRUD PARA VEHICULOS

        public void AddVehicle()
        {
            Console.WriteLine("Porfavor ingresa la Placa del Vehiculo: ");
            string? placa = Console.ReadLine();
            placa = placa.ToLower().Trim();

            Console.WriteLine(@" Porfavor escoge el tipo de Vehiculo:
            1. Moto
            2. Carro
            3. Camioneta
            4. Microbus

            Selecciona el número que corresponda ==>
            
            ");
            string? userVehicle = Console.ReadLine();
            string? vehicleType = null;
            switch(userVehicle)
            {
                case "1":
                vehicleType = "Moto";
                break;
                case "2":
                vehicleType = "Carro";
                break;
                case "3":
                vehicleType = "Camioneta";
                break;
                case "4":
                vehicleType = "Microbus";
                break;
                default:
                Console.WriteLine("Opcion Incorrecta");
                break;
            }

            Console.WriteLine("Porfavor ingresa el numero de Motor: ");
            string? engineNumber = Console.ReadLine();

            Console.WriteLine("Porfavor ingresa el Numero de serie del Vehiculo: ");
            string? serialNumber = Console.ReadLine();

            Console.WriteLine("Cuantos pasajeros caben en el Vehiculo? ");
            byte peopleCapacity = byte.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el Nombre del propietario del Vehiculo");
            string? vehicleOwner = Console.ReadLine();

            Vehicle vehicle = new Vehicle(placa, vehicleType, engineNumber, serialNumber, peopleCapacity, vehicleOwner);

            VehicleList.Add(vehicle);

            Console.WriteLine("Vehiculo agregado con éxito");
        }

        public void ShowAllVehicles()
        {
            Console.WriteLine("Mostrando los Vehiculos registrados");
            foreach (var item in VehicleList)
            {
                item.showVehicles();
            }
        }

        public void DeleteVehicle()
        {
            Console.WriteLine("Ingrese el numero de la placa del vehiculo que desea eliminar: ");
            string? placaEliminar = Console.ReadLine();
            placaEliminar = placaEliminar.ToLower().Trim();
            if(placaEliminar != null)
            {
                Vehicle? vehicle = VehicleList.Find(v => v.Placa == placaEliminar);
                if(vehicle != null )
                {
                    VehicleList.Remove(vehicle);
                    Console.WriteLine("Vehiculo eliminado");
                } else 
                {
                    Console.WriteLine("Vehiculo no encontrado");
                    
                }
            }


        }
    }

}