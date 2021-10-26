using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Items : MonoBehaviour
{
    public int ID;
    public int quantity;
    //public Text quanText;
    public bool isClicked = false;
    private LevelEditor editor;
    public int limit = 0;


    // Start is called before the first frame update
    void Start()
    {

        editor = GameObject.FindGameObjectWithTag("Manager").GetComponent<LevelEditor>();
    }




    public void ButtonClick()
    {
        editor.currentSelect = this.gameObject.GetComponent<Items>().ID;

        if (quantity > 0)
        {
            Vector2 screenPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            Vector2 worldSpacePos = Camera.main.ScreenToWorldPoint(screenPos);
            Instantiate(editor.ItemImage[ID], new Vector3(worldSpacePos.x, worldSpacePos.y, 0.0f), Quaternion.identity);
            isClicked = true;
            quantity--;
            editor.currentSelect = ID;
            
        }
    }

  
}
