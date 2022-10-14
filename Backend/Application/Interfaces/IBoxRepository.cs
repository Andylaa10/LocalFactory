using Domain;

namespace Application.Interfaces;

public interface IBoxRepository
{
    //Create
    Box CreateBox(Box box);

    //Read
    List<Box> GetAllBoxes();
    Box GetBox(int id);
    
    //Update
    Box UpdateBox(Box box, int id);

    //Delete
    Box DeleteBox(int id);
    
    //Rebuild Database
    void RebuildDb();
}