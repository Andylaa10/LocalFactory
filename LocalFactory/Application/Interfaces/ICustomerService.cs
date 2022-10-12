using Domain;

namespace Application.Interfaces;

public interface ICustomerService
{
    //Create
    Customer CreateCustomer(Customer cust);

    //Read
    IEnumerable<Customer> GetAllCustomers();
    Customer GetCustomerById(int id);
    
    //Update
    Customer UpdateCustomer(Customer cust, int id);

    //Delete
    void DeleteCustomer(int id);
}