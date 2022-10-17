using Application.DTOs;
using Domain;

namespace Application.Interfaces;

public interface IOrderRepository
{
    // Create
    /// <summary>
    /// Create a order
    /// </summary>
    /// <param name="order"></param>
    /// <returns>The created order</returns>
    Order CreateOrder(Order order);
    
    // Read
    /// <summary>
    /// Returns all the orders
    /// </summary>
    /// <returns>List of all orders</returns>
    IEnumerable<Order> GetAllOrders();

    /// <summary>
    /// Returns all orders belonging to the customer
    /// </summary>
    /// <param name="customerId"></param>
    /// <returns>List of the customers orders</returns>
    IEnumerable<Order> GetCustomerOrder(int customerId);
    
    /// <summary>
    /// Returns all orders belonging where the box is 
    /// </summary>
    /// <param name="boxId"></param>
    /// <returns>List of orders where the box is</returns>
    IEnumerable<Order> GetBoxOrder(int boxId);
    
    // Delete
    /// <summary>
    /// Deletes a order
    /// </summary>
    /// <param name="id"></param>
    /// <returns>The deleted order</returns>
    Order DeleteOrder(int id);
}