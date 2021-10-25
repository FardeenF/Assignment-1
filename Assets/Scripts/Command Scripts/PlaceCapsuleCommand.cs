using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceCapsuleCommand : ICommand
{
    Vector3 position;
    Color color;
    Transform capsule;

    public PlaceCapsuleCommand(Vector3 position, Color color, Transform capsule)
    {
        this.position = position;
        this.color = color;
        this.capsule = capsule;
    }

    public void Execute()
    {
        CapsulePlacer.PlaceCapsule(position, color, capsule);
    }

    public void Undo()
    {
        CapsulePlacer.RemoveCapsule(position, color);
    }
}
