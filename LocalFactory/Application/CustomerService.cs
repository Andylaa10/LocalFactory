using Application.Interfaces;
using Domain;

namespace Application;

public class CustomerService : ICustomerService
{
    public Customer CreateCustomer(Customer cust)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Customer> GetAllCustomers()
    {
        throw new NotImplementedException();
    }

    public Customer GetCustomer(int id)
    {
        throw new NotImplementedException();
    }

    public Customer UpdateCustomer(Customer cust, int id)
    {
        throw new NotImplementedException();
    }

    public void DeleteCustomer(int id)
    {
        throw new NotImplementedException();
    }
}