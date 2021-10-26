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

    public void Update()
    {
        if (editor.Buttons[ID].quantity >= editor.Buttons[ID].limit)
        {
            editor.Buttons[ID].quantity = editor.Buttons[ID].limit;
        }
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(1))
        {


            Destroy(this.gameObject);
            //this.gameObject.SetActive(false);
            editor.Buttons[ID].quantity++;
            

        }
    }

}

