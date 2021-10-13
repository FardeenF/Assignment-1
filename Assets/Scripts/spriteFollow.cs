//https://www.youtube.com/watch?v=eWBDuEWUOwc

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spriteFollow : MonoBehaviour
{
   

    // Update is called once per frame
    void Update()
    {
        Vector2 screenPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldSpacePos = Camera.main.ScreenToWorldPoint(screenPos);
        transform.position = worldSpacePos;
    }
}
