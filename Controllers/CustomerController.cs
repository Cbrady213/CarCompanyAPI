using CarCompanyAPI.Models;
using CarCompanyAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CarCompanyAPI.Controllers;

[ApiController]
[Route("[controller]")]

public class CustomerController : ControllerBase
{


    public CustomerController()
    {


    }

    [HttpGet]
    public List<Customer> GetAll() => CustomerService.GetAll();




}