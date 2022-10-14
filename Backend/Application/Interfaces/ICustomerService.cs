using Application.DTOs;
using Domain;

namespace Application.Interfaces;

public interface ICustomerService
{
    //Create
    Customer CreateCustomer(PostCustomerDTO cust);

    //Read
    IEnumerable<Customer> GetAllCustomers();
    Customer GetCustomer(int id);
    
    //Update
    Customer UpdateCustomer(PutCustomerDTO cust, int id);

    //Delete
    Customer DeleteCustomer(int id);
}