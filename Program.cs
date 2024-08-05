using TransRiwi.Moduls;

// List<Customer> customers = new List<Customer>
// {
//     new Customer("Premium","TC","Camilo", "Vargas", "Cedula", "1022366999",new DateOnly(2022, 12, 24), "camilo@gmail.com", "322441556"),
// };

public class Program
{
    public static void Main(string[] args)
    {
        Admin admin = new();
        bool run = true;
        while (run)
        {
            Interfaces.Header("TRANSRIWI");
            Console.WriteLine("1. Conductores");
            Console.WriteLine("2. Clientes");
            Console.WriteLine("3. Vehiculos");
            Console.WriteLine("4. Estadisticas");
            Console.WriteLine("5. Salir");
            Console.Write("Ingresa la opción: ");

            string? option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    bool driver = true;
                    while (driver)
                    {
                        Interfaces.Header("TRANSRIWI - CONDUCTORES");
                        Console.WriteLine("1. Registrar conductor");
                        Console.WriteLine("2. Actualizar conductor");
                        Console.WriteLine("3. Eliminar conductor");
                        Console.WriteLine("4. Ver conductores");
                        Console.WriteLine("5. Salir");
                        Console.Write("Ingresa la opción: ");

                        string? optionDriver = Console.ReadLine();
                        switch (optionDriver)
                        {
                            case "1":
                                admin.AddDriver();
                                break;
                            case "2":
                                admin.DriverUpdate();
                                break;
                            case "3":
                                admin.DriverDelete();
                                break;
                            case "4":
                                admin.ShowDrivers();
                                break;
                            case "5":
                                driver = false;
                                break;
                            default:
                                Interfaces.Footer("OPCION NO VALIDA");
                                break;
                        }
                    }
                    break;
                case "2":
                    bool customer = true;
                    while (customer)
                    {
                        Interfaces.Header("TRANSRIWI - CLIENTES");
                        Console.WriteLine("1. Registrar cliente");
                        Console.WriteLine("2. Actualizar cliente");
                        Console.WriteLine("3. Eliminar cliente");
                        Console.WriteLine("4. Ver clientes");
                        Console.WriteLine("5. Salir");
                        Console.Write("Ingresa la opción: ");

                        string? customerOption = Console.ReadLine();
                        switch (customerOption)
                        {
                            case "1":
                                admin.AddCustomer();
                                break;
                            case "2":
                                admin.CustomerUpdate();
                                break;
                            case "3":
                                admin.CustomerDelete();
                                break;
                            case "4":
                                admin.ShowCustomers();
                                break;
                            case "5":
                                customer = false;
                                break;

                            default:
                                Interfaces.Footer("OPCION NO VALIDA");
                                break;

                        }
                    }
                    break;
                case "3":
                    bool vehicle = true;
                    while (vehicle)
                    {
                        Interfaces.Header("TRANSRIWI - VEHICULOS");
                        Console.WriteLine("1. Registrar vehiculo");
                        Console.WriteLine("2. Eliminar vehiculo");
                        Console.WriteLine("3. Ver vehiculos");
                        Console.WriteLine("4. Salir");
                        Console.Write("Ingresa la opción: ");
                        string? vehicleOption = Console.ReadLine();
                        switch (vehicleOption)
                        {
                            case "1":
                                admin.AddVehicle();
                                break;
                            case "2":
                                admin.DeleteVehicle();
                                break;
                            case "3":
                                admin.ShowAllVehicles();
                                break;
                            case "4":
                                vehicle = false;
                                break;

                            default:
                                Interfaces.Footer("OPCION NO VALIDA");
                                break;
                        }
                    }
                    break;




            }
        }
    }

}