using CarCompanyAPI.Models;
using CarCompanyAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CarCompanyAPI.Controllers;

[ApiController]
[Route("[controller]")]

public class CarsController : ControllerBase
{

    public CarsController()
    {

    }

    //

    [HttpGet]

    public List<Car> GetAll() =>

             CarService.GetAll();


  //  [HttpGet("/products")]

   // public Car GetAll2() =>

   // CarService.Get2();



    [HttpPost]

    public void Add(Car car)
    {
        CarService.Add(car);

    }


}



