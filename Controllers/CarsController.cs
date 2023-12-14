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


    [HttpGet("/Cars/Search/model")]

    public List<Car> GetModel(String model) =>

             CarService.SearchModel(model);



    [HttpGet("/Cars/Search/make")]

    public List<Car> Getmake(String make) =>

             CarService.SearchMake(make);


    [HttpGet("/Cars/Search/Condition")]

    public List<Car> getCondition(String condition) => CarService.getCondition(condition);



    //Return cars under a certian price

    [HttpGet("/Cars/Search/budget")]

    public List<Car> GetCarsUnder(int price) => CarService.GetCarsUnder(price);






    //Added Post to allow addition of Cars
    [HttpPost]

    public void Add(Car car)
    {
        CarService.Add(car);

    }


}



