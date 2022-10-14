using Application.DTOs;
using Domain;

namespace Application.Interfaces;

public interface IBoxService
{
    //Create
    Box CreateBox(PostBoxDTO box);

    //Read
    List<Box> GetAllBoxes();
    Box GetBox(int id);
    
    //Update
    Box UpdateBox(PutBoxDTO box, int id);

    //Delete
    Box DeleteBox(int id);
    
    //Rebuild Database
    void RebuildDb();

}