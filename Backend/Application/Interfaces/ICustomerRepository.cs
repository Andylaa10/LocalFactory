using Domain;

namespace Application.Interfaces;

public interface ICustomerRepository
{
    //Create
    Customer CreateCustomer(Customer cust);

    //Read
    IEnumerable<Customer> GetAllCustomers();
    Customer GetCustomer(int id);
    
    //Update
    Customer UpdateCustomer(Customer cust, int id);

    //Delete
    void DeleteCustomer(int id);
}