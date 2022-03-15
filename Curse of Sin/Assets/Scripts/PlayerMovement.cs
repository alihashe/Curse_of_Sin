using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement")]
    [Range(1f, 10f)] public float moveSpeed = 1f;
    float horizontalMove = 0f;
    float verticalMove = 0f;
    public Joystick joy;
    Collider2D collide;
    Rigidbody2D rb;


    void Awake()
    {
        collide = GetComponent<Collider2D>();
        rb = GetComponent<Rigidbody2D>();
        joy = GameObject.FindGameObjectWithTag("JoyStick").GetComponent<Joystick>();
    }

    void FixedUpdate()
    {
        Vector2 moveVelocity = new Vector2(horizontalMove, verticalMove);
        //Horizontal Movement
        if (joy.Horizontal >= .2f)
        {
            while (horizontalMove < moveSpeed)
            {
                horizontalMove += 1f;
            }
        }
        else if (joy.Horizontal <= -.2f)
        {
            while (horizontalMove > -moveSpeed)
            {
                horizontalMove -= 1f;
            }
        }
        else
        {
            horizontalMove = 0f;
        }
        // Vertical Movement
        if (joy.Vertical >= .2f)
        {
            while (verticalMove < moveSpeed)
            {
                verticalMove += 1f;
            }
        }
        else if (joy.Vertical <= -.2f)
        {
            while (verticalMove > -moveSpeed)
            {
                verticalMove -= 1f;
            }
        }
        else
        {
            verticalMove = 0f;
        }

        rb.velocity = moveVelocity;

    }

}