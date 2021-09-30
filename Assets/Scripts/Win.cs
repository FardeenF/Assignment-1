using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    public GameObject menu;
    public GameObject player;
    public GameObject spawnPoint;
    Rigidbody2D rb;
    public static bool win = false;

    private void Start()
    {
        rb = player.GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (Input.GetKey("r") && win)
        {
            rb.position = new Vector2(spawnPoint.transform.position.x, spawnPoint.transform.position.y);
            rb.velocity = new Vector2(0, 0);
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && win)
        {
            Application.Quit();
        }

    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject == player)
        {
            win = true;
            menu.transform.position = new Vector3(17.3f, 21.75f, -5.0f);
            player.GetComponent<PlayerController>().enabled = false;
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject == player)
        {
            win = false;
            menu.transform.position = new Vector3(17.3f, 21.75f, 5.0f);
            player.GetComponent<PlayerController>().enabled = true;
        }
    }

}
