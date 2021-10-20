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
    public GameObject[] currentBlock;
    public int counter = 0;
    

    private void Update()
    {
        Vector2 screenPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldSpacePos = Camera.main.ScreenToWorldPoint(screenPos);

        if (Input.GetMouseButtonDown(0) && Buttons[currentSelect].isClicked == true)
        {
            
            Buttons[currentSelect].isClicked = false;
            currentBlock[counter] = Instantiate(Prefabs[currentSelect], new Vector3(worldSpacePos.x, worldSpacePos.y, 0.0f), Quaternion.identity);
            Destroy(GameObject.FindGameObjectWithTag("ItemImage"));
            counter++;
        }



        RemoveBlock();
        AddBlock();
    }


    void RemoveBlock()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) && currentBlock != null && counter <= currentBlock.Length && counter > 0)
        {
            
            currentBlock[counter - 1].SetActive(false);
            counter--;
            if (currentBlock[counter].gameObject.tag == "Platform")
                currentSelect = 0;
            else if (currentBlock[counter].gameObject.tag == "Jump")
                currentSelect = 1;
            else if (currentBlock[counter].gameObject.tag == "Danger")
                currentSelect = 2;

            Buttons[currentSelect].quantity++;
        }
    }

    void AddBlock()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) && currentBlock[counter] != null && counter < currentBlock.Length)
        {
            currentBlock[counter].SetActive(true);
            
            if (currentBlock[counter].gameObject.tag == "Platform")
                currentSelect = 0;
            else if (currentBlock[counter].gameObject.tag == "Jump")
                currentSelect = 1;
            else if (currentBlock[counter].gameObject.tag == "Danger")
                currentSelect = 2;

            Buttons[currentSelect].quantity--;
            counter++;
        }
    }
}
