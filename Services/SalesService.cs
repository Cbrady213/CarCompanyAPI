using CarCompanyAPI.Models;
using CarCompanyAPI.Controllers;

namespace CarCompanyAPI.Services;

public class SalesService

{

    static List<Sale> sales;

    static SalesService()
    {
        sales = new List<Sale>
        {
            new Sale {Id = 1, CarId = 2, CustomerId = 1}


        };



    }


    public static List<Sale> GetAll()
    {

        return sales;
    }


}