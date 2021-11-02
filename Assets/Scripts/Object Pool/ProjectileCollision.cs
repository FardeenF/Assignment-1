using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Platform")
        {
            Debug.Log("HIT!");
            Destroy(col.gameObject);
            gameObject.SetActive(false);
        }
    }
}
