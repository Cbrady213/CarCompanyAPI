using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using CarCompanyAPI.Models;

namespace CarCompanyAPI.Services;

public static class CarService

{
  //Creation of a static list of test data,  Int in a Static Constructor 
  static List<Car> Cars;
  static CarService()
  {
    Cars = new List<Car>
      {
        new Car { Make = "Toyota", Model = "Corolla", Year = 2022, Color = "Red", Mileage = 20000, Price = 22000, EngineType = "Hybrid", Transmission = "Automatic", FuelEfficiency = 50, Condition = "Used", Location = "Chicago, IL", SellerName = "Mike Jones", SellerContact = "(123) 456-7890" },
        new Car { Make = "Honda", Model = "Accord", Year = 2020, Color = "White", Mileage = 45000, Price = 25000, EngineType = "Gas", Transmission = "CVT", FuelEfficiency = 35, Condition = "Used", Location = "New York City, NY", SellerName = "Sarah Lee", SellerContact = "(987) 654-3210" },
        new Car { Make = "Ford", Model = "Mustang", Year = 2023, Color = "Black", Mileage = 10000, Price = 38000, EngineType = "V8", Transmission = "Manual", FuelEfficiency = 20, Condition = "New", Location = "Los Angeles, CA", SellerName = "David Smith", SellerContact = "(555) 000-9999" },
        new Car { Make = "Toyota", Model = "Camry", Year = 2023, Color = "Silver", Mileage = 15000, Price = 25000, EngineType = "Gas", Transmission = "Automatic", FuelEfficiency = 35, Condition = "New", Location = "Los Angeles, CA", SellerName = "John Doe", SellerContact = "(555) 555-5555" },
        new Car { Make = "Honda", Model = "Civic", Year = 2022, Color = "Blue", Mileage = 30000, Price = 18000, EngineType = "Gas", Transmission = "Manual", FuelEfficiency = 40, Condition = "Used", Location = "San Francisco, CA", SellerName = "Jane Doe", SellerContact = "(444) 444-4444" },
        new Car { Make = "Hyundai", Model = "Elantra", Year = 2021, Color = "White", Mileage = 25000, Price = 19000, EngineType = "Hybrid", Transmission = "Automatic", FuelEfficiency = 50, Condition = "Used", Location = "Seattle, WA", SellerName = "Sarah Lee", SellerContact = "(333) 333-3333" },
        new Car { Make = "Chevrolet", Model = "Camaro", Year = 2023, Color = "Red", Mileage = 12000, Price = 35000, EngineType = "V6", Transmission = "Automatic", FuelEfficiency = 25, Condition = "New", Location = "Miami, FL", SellerName = "Mike Jones", SellerContact = "(123) 456-7890" },
        new Car { Make = "Kia", Model = "Forte", Year = 2022, Color = "Black", Mileage = 40000, Price = 15000, EngineType = "Gas", Transmission = "Automatic", FuelEfficiency = 35, Condition = "Used", Location = "New York City, NY", SellerName = "David Smith", SellerContact = "(555) 000-9999" },
        new Car { Make = "Kia", Model = "Forte", Year = 2022, Color = "Blue", Mileage = 8000, Price = 7500, EngineType = "Gas", Transmission = "Automatic", FuelEfficiency = 35, Condition = "Used", Location = "New York City, NY", SellerName = "David james", SellerContact = "(555) 000-7263" },
        // SUVs
        new Car { Make = "Toyota", Model = "Highlander", Year = 2024, Color = "Gray", Mileage = 10000, Price = 42000, EngineType = "Hybrid", Transmission = "Automatic", FuelEfficiency = 30, Condition = "New", Location = "Denver, CO", SellerName = "Emma Smith", SellerContact = "(777) 777-7777" },
        new Car { Make = "Honda", Model = "Passport", Year = 2023, Color = "Green", Mileage = 20000, Price = 38000, EngineType = "Gas", Transmission = "Automatic", FuelEfficiency = 22, Condition = "Used", Location = "Austin, TX", SellerName = "Mark Jones", SellerContact = "(888) 888-8888" },
        new Car { Make = "Ford", Model = "Explorer", Year = 2022, Color = "Blue", Mileage = 45000, Price = 35000, EngineType = "Turbo", Transmission = "Automatic", FuelEfficiency = 20, Condition = "Used", Location = "Chicago, IL", SellerName = "Sarah Lee", SellerContact = "(999) 999-9999" },

        // Trucks
        new Car { Make = "Ford", Model = "F-150", Year = 2023, Color = "Black", Mileage = 15000, Price = 50000, EngineType = "V8", Transmission = "Automatic", FuelEfficiency = 18, Condition = "New", Location = "Dallas, TX", SellerName = "Mike Johnson", SellerContact = "(000) 000-0000" },
        new Car { Make = "Chevrolet", Model = "Silverado", Year = 2022, Color = "Red", Mileage = 30000, Price = 45000, EngineType = "Diesel", Transmission = "Automatic", FuelEfficiency = 25, Condition = "Used", Location = "Phoenix, AZ", SellerName = "David Smith", SellerContact = "(123) 456-7890" },
        new Car { Make = "Ram", Model = "1500", Year = 2021, Color = "White", Mileage = 50000, Price = 40000, EngineType = "V6", Transmission = "Automatic", FuelEfficiency = 20, Condition = "Used", Location = "Atlanta, GA", SellerName = "Jane Doe", SellerContact = "(444) 444-4444" },

        // Sports Cars
        new Car { Make = "Chevrolet", Model = "Corvette", Year = 2024, Color = "Yellow", Mileage = 5000, Price = 80000, EngineType = "V8", Transmission = "Manual", FuelEfficiency = 15, Condition = "New", Location = "Los Angeles, CA", SellerName = "Mark Jones", SellerContact = "(888) 888-8888" },
        new Car { Make = "Porsche", Model = "911", Year = 2023, Color = "Silver", Mileage = 10000, Price = 120000, EngineType = "Turbo", Transmission = "Automatic", FuelEfficiency = 20, Condition = "Used", Location = "Miami, FL", SellerName = "Emma Smith", SellerContact = "(777) 777-7777" },
        new Car { Make = "Toyota", Model = "GR86", Year = 2022, Color = "Blue", Mileage = 25000, Price = 30000, EngineType = "Boxer", Transmission = "Manual", FuelEfficiency = 30, Condition = "Used", Location = "Seattle, WA", SellerName = "David Smith", SellerContact = "(555) 000-9999" }




      };
  }

  public static List<Car> GetAll()
  {


    return Cars;

  }

  public static List<Car> SearchModel(String model)
  {

    List<Car> modelSearch = new List<Car>();

    foreach (Car car in Cars)
    {
      if (car.Model == model)
      {
        modelSearch.Add(car);
      }


    }
    return modelSearch;

  }

  public static void Add(Car car)

  {


  }

}

