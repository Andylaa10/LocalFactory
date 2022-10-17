using Application.Interfaces;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class BoxRepository : IBoxRepository
{
    private RepositoryDbContext _context;
    private IOrderRepository _repository;
    

    public BoxRepository(RepositoryDbContext context)
    {
        _context = context;
    }

    public Box CreateBox(Box box)
    {
        _context.Boxes.Add(box);
        _context.SaveChanges();
        return box;
    }

    public List<Box> GetAllBoxes()
    {
        return _context.Boxes.ToList();
    }

    public Box GetBox(int id)
    {
        _repository = new OrderRepository(_context);
        var box = _context.Boxes.FirstOrDefault(b=> b.Id == id);
        box.Orders = _repository.GetBoxOrder(box.Id).ToList();
        return box;
    }

    public Box UpdateBox(Box box, int id)
    {
        var b = _context.Boxes.FirstOrDefault(b => b.Id == id);
        if (b.Id == id)
        {
            b.BoxName = box.BoxName;
            b.Description = box.Description;
            b.Price = box.Price;
            _context.Update(b);
            _context.SaveChanges();
        }
        return b;
    }

    public Box DeleteBox(int id)
    {
        var box = _context.Boxes.FirstOrDefault(b => b.Id == id);
        _context.Boxes.Remove(box);
        _context.SaveChanges();
        return box;
    }

    public void RebuildDb()
    {
        _context.Database.EnsureDeleted();
        _context.Database.EnsureCreated();
    }
}
