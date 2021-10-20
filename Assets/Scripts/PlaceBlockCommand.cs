using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceBlockCommand : ICommand
{
    int id;
    GameObject block;

    public PlaceBlockCommand(int ID, GameObject Block)
    {
        this.id = ID;
        this.block = Block;
    }

    public void Execute()
    {
        //LevelEditor.AddBlock();
    }

    public void Undo()
    {
        //LevelEditor.RemoveBlock();
    }
}
