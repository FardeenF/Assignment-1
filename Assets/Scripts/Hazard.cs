using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour
{
    public GameObject spawnPoint;

    private void OnCollisionEnter2D(Collision2D col)
    {
        col.gameObject.transform.position = new Vector3(spawnPoint.transform.position.x, spawnPoint.transform.position.y, -5);
        col.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        
    }
}
