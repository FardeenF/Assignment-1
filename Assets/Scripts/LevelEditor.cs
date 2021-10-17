//https://www.youtube.com/watch?v=eWBDuEWUOwc 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEditor : MonoBehaviour
{
    public Items[] Buttons;
    public GameObject[] Prefabs;
    public GameObject[] ItemImage;
    public int currentSelect;
    public GameObject currentBlock;


    private void Update()
    {
        Vector2 screenPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldSpacePos = Camera.main.ScreenToWorldPoint(screenPos);

        if (Input.GetMouseButtonDown(0) && Buttons[currentSelect].isClicked == true)
        {
            Buttons[currentSelect].isClicked = false;
            currentBlock = Instantiate(Prefabs[currentSelect], new Vector3(worldSpacePos.x, worldSpacePos.y, 0.0f), Quaternion.identity);
            Destroy(GameObject.FindGameObjectWithTag("ItemImage"));
        }
        

        if (Input.GetKeyDown(KeyCode.LeftArrow) && currentBlock != null)
        {
            currentBlock.SetActive(false);
            Buttons[currentSelect].quantity++;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) && currentBlock != null)
        {
            currentBlock.SetActive(true);
            Buttons[currentSelect].quantity--;
        }
    }
}
