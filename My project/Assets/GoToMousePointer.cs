using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToMousePointer : MonoBehaviour
{
    public float moveSpeed = 9f;

    public Rigidbody2D rb;

    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {      
<<<<<<< HEAD:2022 Game Jam/Assets/GoToMousePointer.cs
        transform.position = new Vector3(((Input.mousePosition.x - 550) / 30), (Input.mousePosition.y - 262) / 30, -4);
=======
        transform.position = new Vector3(((Input.mousePosition.x - 550) / 30), (Input.mousePosition.y - 262) / 30, 0);
>>>>>>> parent of 13a7f53 (changed name of project folder):My project/Assets/GoToMousePointer.cs
        //rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

    }
}
