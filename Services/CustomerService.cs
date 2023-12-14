using CarCompanyAPI.Models;
using CarCompanyAPI.Controllers;

namespace CarCompanyAPI.Services;


public static class CustomerService

{
    static List<Customer> customers;

    static CustomerService()
    {
        customers = new List<Customer>
        {
        new Customer {Id=1,FirstName="Ciaran",LastName="Brady",Email="test@gmail.com",PhoneNumber=999,Address="123 fake street"}

        };


    }


    public static List<Customer> GetAll()
    {
        return customers;
    }


}






