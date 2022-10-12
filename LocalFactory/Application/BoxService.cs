using Application.Interfaces;
using Domain;

namespace Application;

public class BoxService : IBoxService
{
    private IBoxRepository _repository;
    public BoxService(IBoxRepository repository)
    {
        _repository = repository;
    }

    public Box CreateBox(Box box)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Box> GetAllBoxes()
    {
        throw new NotImplementedException();
    }

    public Box GetBox(int id)
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

    public void RebuildDb()
    {
        _repository.RebuildDb();
    }
}