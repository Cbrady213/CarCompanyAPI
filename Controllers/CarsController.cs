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


    [HttpGet("/Cars/Search")]

    public List<Car> GetAll2(String model)=>

             CarService.SearchModel(model);
    

    



    [HttpPost]

    public void Add(Car car)
    {
        CarService.Add(car);

    }


}



