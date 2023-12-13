using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using CarCompanyAPI.Models;

namespace CarCompanyAPI.Services;

public static class CarService

{
  static List<Car> Cars;
  static CarService()
  {
    Cars = new List<Car>
      {
        new Car { Make = "Toyota", Model = "Corolla", Year = 2022, Color = "Red", Mileage = 20000, Price = 22000, EngineType = "Hybrid", Transmission = "Automatic", FuelEfficiency = 50, Condition = "Used", Location = "Chicago, IL", SellerName = "Mike Jones", SellerContact = "(123) 456-7890" },
        new Car { Make = "Honda", Model = "Accord", Year = 2020, Color = "White", Mileage = 45000, Price = 25000, EngineType = "Gas", Transmission = "CVT", FuelEfficiency = 35, Condition = "Used", Location = "New York City, NY", SellerName = "Sarah Lee", SellerContact = "(987) 654-3210" },
        new Car { Make = "Ford", Model = "Mustang", Year = 2023, Color = "Black", Mileage = 10000, Price = 38000, EngineType = "V8", Transmission = "Manual", FuelEfficiency = 20, Condition = "New", Location = "Los Angeles, CA", SellerName = "David Smith", SellerContact = "(555) 000-9999" }


      };
  }

  public static List<Car> GetAll()
  {


    return Cars ;

  }

  //public static Car Get2()
  //{

    //return car;

 // }

  public static void Add(Car car)

  {


  }

}

