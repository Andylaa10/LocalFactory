using Application.Interfaces;
using Domain;

namespace Infrastructure;

public class FactoryRepository : IFactoryRepository
{
    public Factory CreateFactory(Factory fac)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Factory> GetAllFactories()
    {
        throw new NotImplementedException();
    }

    public Factory GetFactoryById(int id)
    {
        throw new NotImplementedException();
    }

    public Factory UpdateFactory(Factory fac, int id)
    {
        throw new NotImplementedException();
    }

    public void DeleteFactory(int id)
    {
        throw new NotImplementedException();
    }

    public void RebuildDb()
    {
        throw new NotImplementedException();
    }
}