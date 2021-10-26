using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveButton : MonoBehaviour
{
    public bool isPlatformActive;
    public bool isJumpPadActive;
    public bool isHazardActive;

    private void Awake()
    {
        isPlatformActive = false;
        isJumpPadActive = false;
        isHazardActive = false;
    }

    public void platformCheck()
    {
        isPlatformActive = true;
        Debug.Log("Platform Active");
    }

    public void jumpPadCheck()
    {
        isJumpPadActive = true;
        Debug.Log("Jump Active");
    }

    public void hazardCheck()
    {
        isHazardActive = true;
        Debug.Log("Hazard Active");
    }
}
