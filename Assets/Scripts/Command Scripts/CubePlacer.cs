using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubePlacer : MonoBehaviour
{
    static List<Transform> cubes;

    public static void PlaceCube(Vector3 position, Color color, Transform cube)
    {
        Transform newCube = Instantiate(cube, position, Quaternion.identity);
        if (cubes == null){
            cubes = new List<Transform>();
        }
        cubes.Add(newCube);
    }

    public static void RemoveCube(Vector3 position, Color color)
    {
        for (int i = 0; i < cubes.Count; i++){
            if (cubes[i].position == position) 
            {
                GameObject.Destroy(cubes[i].gameObject);
                cubes.RemoveAt(i);
                break;
            }
        }
    }
}
