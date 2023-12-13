using CarCompanyAPI.Models;

namespace CarCompanyAPI.Services;

public static class CarService

{
    static Car car{get;set;}
    static CarService()
    {
      car = new Car { Id = 1, Make = "vw", Model = "gold", IsSold = false };
    }

    public static Car Get()
    {

        return car;

    }

}

