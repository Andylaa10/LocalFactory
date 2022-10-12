using Application.Interfaces;
using Domain;

namespace Infrastructure;

public class BoxRepository : IBoxRepository
{
    public Box CreateBox(Box box)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Box> GetAllBoxes()
    {
        throw new NotImplementedException();
    }

    public Box GetBoxById(int id)
    {
        throw new NotImplementedException();
    }

    public Box UpdateBox(Box box, int id)
    {
        throw new NotImplementedException();
    }

    public void DeleteBox(int id)
    {
        throw new NotImplementedException();
    }
}