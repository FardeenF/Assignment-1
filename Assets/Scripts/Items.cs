using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Items : MonoBehaviour
{
    public int ID;
    public int quantity;
    public Text quanText;
    public bool isClicked = false;
    private LevelEditor editor;

    


    // Start is called before the first frame update
    void Start()
    {
        quanText.text = quantity.ToString();
        editor = GameObject.FindGameObjectWithTag("Manager").GetComponent<LevelEditor>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))
            quanText.text = quantity.ToString();
    }


    public void ButtonClick()
    {
        if (quantity > 0)
        {
            Vector2 screenPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            Vector2 worldSpacePos = Camera.main.ScreenToWorldPoint(screenPos);
            Instantiate(editor.ItemImage[ID], new Vector3(worldSpacePos.x, worldSpacePos.y, 0.0f), Quaternion.identity);
            isClicked = true;
            quantity--;
            quanText.text = quantity.ToString();
            editor.currentSelect = ID;
        }
    }

  
}
