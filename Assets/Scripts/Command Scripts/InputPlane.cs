using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputPlane : MonoBehaviour
{
    Camera maincam;
    RaycastHit hitInfo;
    RaycastHit hitInfo2;
    public Transform cubePrefab;
    public Transform capsulePrefab;
    private int shapesPlaced;

    // Start is called before the first frame update
    void Awake()
    {
        maincam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = maincam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hitInfo, Mathf.Infinity))
            {
                Color c = new Color(Random.Range(0.5f, 1f), Random.Range(0.5f, 1f), Random.Range(0.5f, 1f));
                //CubePlacer.PlaceCube(hitInfo.point, c, cubePrefab);

                ICommand command = new PlaceCubeCommand(hitInfo.point, c, cubePrefab);
                CommandInvoker.AddCommand(command);

                //CubePlace cube = new CubePlace();
                //cube.PlaceShape(hitInfo.point, c, cubePrefab);
                shapesPlaced++;
                Debug.Log("Shapes Placed: " + shapesPlaced);
            }
        }

        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = maincam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hitInfo2, Mathf.Infinity))
            {
                Color c = new Color(Random.Range(0.5f, 1f), Random.Range(0.5f, 1f), Random.Range(0.5f, 1f));

                ICommand command2 = new PlaceCubeCommand(hitInfo2.point, c, capsulePrefab);
                CommandInvoker.AddCommand(command2);

                //CapsulePlace capsule = new CapsulePlace();
                //capsule.PlaceShape(hitInfo2.point, c, capsulePrefab);
                shapesPlaced++;
                Debug.Log("Shapes Placed: " + shapesPlaced);
            }
        }

    }
}
