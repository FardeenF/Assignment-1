using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceSkull : MonoBehaviour
{
    public Transform spawnPoint;
    public Sprite image;

    public void skullClick()
    {
        SkullObject skull = new SkullObject();
        skull.createObject(spawnPoint.position, spawnPoint, image);
    }
}
