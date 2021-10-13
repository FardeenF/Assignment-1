//https://www.youtube.com/watch?v=eWBDuEWUOwc

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDeleter : MonoBehaviour
{
    
    public int ID;
    private LevelEditor editor;
    private void Start()
    {
        editor = GameObject.FindGameObjectWithTag("Manager").GetComponent<LevelEditor>();
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(1))
        {


            Destroy(this.gameObject);
            editor.Buttons[ID].quantity++;
            editor.Buttons[ID].quanText.text = editor.Buttons[ID].quantity.ToString();


        }
    }

}

