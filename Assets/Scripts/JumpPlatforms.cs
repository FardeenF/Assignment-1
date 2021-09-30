using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPlatforms : MonoBehaviour
{
    public float jumpForce = 5.0f;

    private void OnCollisionEnter2D(Collision2D col)
    {
        col.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }
}
