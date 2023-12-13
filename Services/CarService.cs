using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using CarCompanyAPI.Models;

namespace CarCompanyAPI.Services;

public static class CarService

{
    static Car car{get;}
    static CarService()
    {
      car = new Car { Id = 1, Make = "vw", Model = "gold", IsSold = false };
    }

    public static Car Get()
    {
      Car car2 = new Car();
      if (car.IsSold==false)
      
      {car2 = car;}

        return car2;

    }

    public static void Add(Car car)
  
    {
      

    }

}

