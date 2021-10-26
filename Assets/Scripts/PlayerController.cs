using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.InteropServices;

public class PlayerController : MonoBehaviour
{
    Animator anim;
    Rigidbody2D rb;
    SpriteRenderer sprite;

    public GameObject spawnPoint;
    public float jumpForce = 5.0f;

    public Transform groundCheck;

    private bool isGrounded;

    public static event Action jumpPerformed;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w") && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            anim.Play("Player_Jump");

            #region observer
            jumpPerformed?.Invoke();
            #endregion
        }

        if (rb.position.y < -20.0f)
        {
            rb.position = new Vector2(spawnPoint.transform.position.x, spawnPoint.transform.position.y);
            rb.velocity = new Vector2(0, 0);
        }
    }

    private void FixedUpdate()
    {
        if(Input.GetKey("d"))
        {
            rb.velocity = new Vector2(2, rb.velocity.y);

            if(isGrounded)
                anim.Play("Player_Walk");

            sprite.flipX = false;
        }
        else if (Input.GetKey("a"))
        {
            rb.velocity = new Vector2(-2, rb.velocity.y);

            if (isGrounded)
                anim.Play("Player_Walk");

            sprite.flipX = true;
        }
        else
        {
            if (isGrounded)
                anim.Play("Player_Idle");

            rb.velocity = new Vector2(0, rb.velocity.y);
        }

        if(Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground")))
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
            anim.Play("Player_Jump");
        }
    }




}
