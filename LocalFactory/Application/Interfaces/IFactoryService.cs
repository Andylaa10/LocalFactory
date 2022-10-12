using Domain;

namespace Application.Interfaces;

public interface IFactoryService
{
    //Create
    Factory CreateFactory(Factory fac);

    //Read
    IEnumerable<Factory> GetAllFactories();
    Factory GetFactory(int id);
    
    //Update
    Factory UpdateFactory(Factory fac, int id);

    //Delete
    void DeleteFactory(int id);
    
    //Rebuild database
    void RebuildDb();
}