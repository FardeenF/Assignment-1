using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockInput : MonoBehaviour
{
    public ActiveButton buttonCheck;

    public Transform platformPrefab;
    public Transform jumpPadPrefab;
    public Transform hazardPrefab;

    private int shapesPlaced;

    private Transform activePrefab;

    // Start is called before the first frame update
    void Awake()
    {
        buttonCheck.GetComponent<ActiveButton>();
    }

    // Update is called once per frame
    void Update()
    {
        if (buttonCheck.isPlatformActive)
        {
            activePrefab = platformPrefab;
        }
        else if (buttonCheck.isJumpPadActive)
        {
            activePrefab = jumpPadPrefab;
        }
        else if (buttonCheck.isHazardActive)
        {
            activePrefab = hazardPrefab;
        }
        else
        {
            activePrefab = null;
        }

        Vector2 screenPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldSpacePos = Camera.main.ScreenToWorldPoint(screenPos);

        if (Input.GetMouseButtonDown(0) && buttonCheck.isPlatformActive)
        {

            Color c = new Color(Random.Range(0.5f, 1f), Random.Range(0.5f, 1f), Random.Range(0.5f, 1f));

            ICommand command = new PlaceCubeCommand(worldSpacePos, c, platformPrefab);
            CommandInvoker.AddCommand(command);

            shapesPlaced++;

            buttonCheck.isPlatformActive = false;
        }


        if (Input.GetMouseButtonDown(0) && buttonCheck.isJumpPadActive)
        {

            Color c = new Color(Random.Range(0.5f, 1f), Random.Range(0.5f, 1f), Random.Range(0.5f, 1f));

            ICommand command = new PlaceCubeCommand(worldSpacePos, c, jumpPadPrefab);
            CommandInvoker.AddCommand(command);

            shapesPlaced++;

            buttonCheck.isJumpPadActive = false;
        }

        if (Input.GetMouseButtonDown(0) && buttonCheck.isHazardActive)
        {

            Color c = new Color(Random.Range(0.5f, 1f), Random.Range(0.5f, 1f), Random.Range(0.5f, 1f));
            //CubePlacer.PlaceCube(hitInfo.point, c, cubePrefab);

            ICommand command = new PlaceCubeCommand(worldSpacePos, c, hazardPrefab);
            CommandInvoker.AddCommand(command);

            //CubePlace cube = new CubePlace();
            //cube.PlaceShape(hitInfo.point, c, cubePrefab);
            shapesPlaced++;

            buttonCheck.isHazardActive = false;
        }

    }
}
