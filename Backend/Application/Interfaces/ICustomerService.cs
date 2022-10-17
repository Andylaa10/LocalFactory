using Application.DTOs;
using Domain;

namespace Application.Interfaces;

public interface ICustomerService
{
    //Create
    /// <summary>
    /// Create customer using postCustomerDTO
    /// </summary>
    /// <param name="cust"></param>
    /// <returns>The created customer</returns>
    Customer CreateCustomer(PostCustomerDTO cust);

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
    /// Updates customer using the putCustomerDTO + id
    /// </summary>
    /// <param name="cust"></param>
    /// <param name="id"></param>
    /// <returns>Updated customer</returns>
    Customer UpdateCustomer(PutCustomerDTO cust, int id);

    //Delete
    /// <summary>
    /// Deletes customer
    /// </summary>
    /// <param name="id"></param>
    /// <returns>The deleted customer</returns>
    Customer DeleteCustomer(int id);
}