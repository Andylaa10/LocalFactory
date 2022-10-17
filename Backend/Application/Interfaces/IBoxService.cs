using Application.DTOs;
using Domain;

namespace Application.Interfaces;

public interface IBoxService
{
    //Create
    /// <summary>
    /// Create box using postBoxDTO
    /// </summary>
    /// <param name="box"></param>
    /// <returns>The created box</returns>
    Box CreateBox(PostBoxDTO box);

    //Read
    /// <summary>
    /// Returns all boxes
    /// </summary>
    /// <returns>List of all boxes</returns>
    List<Box> GetAllBoxes();
    /// <summary>
    /// Returns the desired box
    /// </summary>
    /// <param name="id"></param>
    /// <returns>The desired box</returns>
    Box GetBox(int id);
    
    //Update
    /// <summary>
    /// Update box using putBoxDTO + id
    /// </summary>
    /// <param name="box"></param>
    /// <param name="id"></param>
    /// <returns>The updated box</returns>
    Box UpdateBox(PutBoxDTO box, int id);

    //Delete
    /// <summary>
    /// Deletes box
    /// </summary>
    /// <param name="id"></param>
    /// <returns>The deleted box</returns>
    Box DeleteBox(int id);
    
    //Rebuild Database
    /// <summary>
    /// Rebuild the database
    /// </summary>
    void RebuildDb();

}