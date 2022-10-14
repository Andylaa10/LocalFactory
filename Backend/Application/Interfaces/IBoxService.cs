﻿using Domain;

namespace Application.Interfaces;

public interface IBoxService
{
    //Create
    Box CreateBox(Box box);

    //Read
    IEnumerable<Box> GetAllBoxes();
    Box GetBox(int id);
    
    //Update
    Box UpdateBox(Box box, int id);

    //Delete
    void DeleteBox(int id);
    
    //Rebuild Database
    void RebuildDb();

}