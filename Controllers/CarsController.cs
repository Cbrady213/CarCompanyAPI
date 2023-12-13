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
   
    public Car GetAll()=>
    
            CarService.Get();

        [HttpPost]

        public void Add(Car car)
        {
            CarService.Add(car);

        }
   

}



