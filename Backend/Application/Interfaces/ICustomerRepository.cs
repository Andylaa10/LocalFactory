using Domain;

namespace Application.Interfaces;

public interface ICustomerRepository
{
    //Create
    /// <summary>
    /// Creates a customer
    /// </summary>
    /// <param name="cust"></param>
    /// <returns>The created customer</returns>
    Customer CreateCustomer(Customer cust);

    //Read
    /// <summary>
    /// Returns a list of all customers
    /// </summary>
    /// <returns>List of all customers</returns>
    IEnumerable<Customer> GetAllCustomers();
    
    /// <summary>
    /// Get the desired customer by using the id
    /// </summary>
    /// <param name="id"></param>
    /// <returns>The desired customer</returns>
    Customer GetCustomer(int id);
    
    //Update
    /// <summary>
    /// Updates customer
    /// </summary>
    /// <param name="cust"></param>
    /// <param name="id"></param>
    /// <returns>Updated customer</returns>
    Customer UpdateCustomer(Customer cust, int id);

    //Delete
    /// <summary>
    /// Deletes customer
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Customer DeleteCustomer(int id);
}