using Application.Interfaces;
using Domain;

namespace Infrastructure;

public class BoxRepository : IBoxRepository
{
    private RepositoryDbContext _context;

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

    public IEnumerable<Box> GetAllBoxes()
    {
        return _context.Boxes.ToList();
    }

    public Box GetBox(int id)
    {
        var box = _context.Boxes.FirstOrDefault(b=> b.Id == id);
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
            b.CustomerId = box.CustomerId;
            _context.Update(b);
            _context.SaveChanges();
        }
        return b;
    }

    public void DeleteBox(int id)
    {
        var box = _context.Boxes.FirstOrDefault(b => b.Id == id);
        _context.Boxes.Remove(box);
        _context.SaveChanges();
    }

    public void RebuildDb()
    {
        _context.Database.EnsureDeleted();
        _context.Database.EnsureCreated();
    }
}