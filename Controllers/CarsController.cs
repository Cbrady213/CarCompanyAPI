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

    //Get Request to return all Cars

    [HttpGet]

    public List<Car> GetAll() =>

             CarService.GetAll();


    //Get Request to return all cars of a particualr Model


    [HttpGet("/Cars/Search")]

    public List<Car> GetAll2(String model)=>

             CarService.SearchModel(model);
    

    


    //Working to add addition of cars, not implemented yet!!
    [HttpPost]

    public void Add(Car car)
    {
        CarService.Add(car);

    }


}



