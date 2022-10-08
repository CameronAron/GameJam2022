using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float moveSpeed = 9f;

    public Rigidbody2D rb;

    Vector2 movement;

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if (Input.GetKeyDown("space"))
        {
            transform.position = new Vector3(0, 0, -1);
        }
    }

    void FixedUpdate()
    {
        if (rb.position.x > 10.001)
        {
            transform.position = new Vector3(10, transform.position.y, -1);
        }

        if (rb.position.x < -10.001)
        {
            transform.position = new Vector3(-10, transform.position.y, -1);
        }

        if (rb.position.y > 8.001)
        {
            transform.position = new Vector3(transform.position.x, 8, -1);
        }

        if (rb.position.y < -8.001)
        {
            transform.position = new Vector3(transform.position.x, -8, -1);
        }

        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        
    }
}
