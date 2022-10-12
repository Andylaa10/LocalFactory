using Application.Interfaces;
using Domain;

namespace Infrastructure;

public class CustomerRepository : ICustomerRepository
{
    private RepositoryDbContext _context;

    public CustomerRepository(RepositoryDbContext context)
    {
        _context = context;
    }
    public Customer CreateCustomer(Customer cust)
    {
        _context.Customer.Add(cust);
        _context.SaveChanges();
        return cust;
    }

    public IEnumerable<Customer> GetAllCustomers()
    {
        return _context.Customer.ToList();
    }

    public Customer GetCustomer(int id)
    {
        var cust = _context.Customer.FirstOrDefault(c => c.Id == id);
        return cust;
    }

    public Customer UpdateCustomer(Customer cust, int id)
    {
        var customer = _context.Customer.FirstOrDefault(c => c.Id == id);
        if (customer.Id == id)
        {
            customer.CustomerName = cust.CustomerName;
            customer.Email = cust.Email;
            _context.Update(customer);
            _context.SaveChanges();
        }

        return customer;
    }

    public void DeleteCustomer(int id)
    {
        var cust = _context.Customer.FirstOrDefault(C => C.Id == id);
        _context.Customer.Remove(cust);
        _context.SaveChanges();
    }
}