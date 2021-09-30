using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    private static bool hasWon;

    Win winScript;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        hasWon = Win.win;

        if (hasWon)
        {
            Debug.Log("This has been triggered.");
            transform.position = new Vector3(17.3f, 22.75f, -15.0f);
        }
        else
        {
            transform.position = new Vector3(17.3f, 22.75f, 15.0f);
        }
    }
}
