using Application.DTOs;
using Application.Interfaces;
using Domain;

namespace Infrastructure;

public class OrderRepository : IOrderRepository
{
    private RepositoryDbContext _context;

    public OrderRepository(RepositoryDbContext context)
    {
        _context = context;
    }

    public Order CreateOrder(Order order)
    {
        _context.Orders.Add(order);
        _context.SaveChanges();
        return order;
    }

    public IEnumerable<Order> GetAllOrders()
    {
        return _context.Orders.ToList();
    }

    public IEnumerable<Order> GetCustomerOrder(int customerId)
    {
        return _context.Orders.ToList().Where(o => o.CustomerId == customerId).Select(o => o);
    }
    
    public IEnumerable<Order> GetBoxOrder(int boxId)
    {
        return _context.Orders.ToList().Where(o => o.BoxId == boxId).Select(o => o);
    }

    public Order DeleteOrder(int id)
    {
        var order = _context.Orders.FirstOrDefault(C => C.Id == id);
        _context.Orders.Remove(order);
        _context.SaveChanges();
        return order;
    }
}