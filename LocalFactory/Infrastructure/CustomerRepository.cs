using Application.Interfaces;
using Domain;

namespace Infrastructure;

public class CustomerRepository : ICustomerRepository
{
    public Customer CreateCustomer(Customer cust)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Customer> GetAllCustomers()
    {
        throw new NotImplementedException();
    }

    public Customer GetCustomerById(int id)
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