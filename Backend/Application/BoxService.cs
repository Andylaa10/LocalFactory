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
        return _repository.CreateBox(box);
    }

    public IEnumerable<Box> GetAllBoxes()
    {
        return _repository.GetAllBoxes();
    }

    public Box GetBox(int id)
    {
        return _repository.GetBox(id);
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