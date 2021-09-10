using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    public float jumpForce;
    private float velocityX;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Movement();
        Jump();
    }

    private void Movement()
    {
        velocityX = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(velocityX * speed * Time.fixedDeltaTime, rb.velocity.y);
    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = Vector2.up * jumpForce * Time.fixedDeltaTime;
        }
    }
}
