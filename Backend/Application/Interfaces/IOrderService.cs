
using Application.DTOs;
using Domain;

namespace Application.Interfaces;

public interface IOrderService
{
    // Create
    /// <summary>
    /// Create a order, using the postOrderDTO
    /// </summary>
    /// <param name="dto"></param>
    /// <returns>The created Order</returns>
    Order CreateOrder(PostOrderDTO dto);
    
    // Read
    /// <summary>
    /// Returns all the orders
    /// </summary>
    /// <returns>List of all orders</returns>
    IEnumerable<Order> GetAllOrders();

    /// <summary>
    /// Returns all orders belonging to the customerId
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