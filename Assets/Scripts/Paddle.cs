using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public KeyCode Up, Down;
    public float speed = 1;
    private float y;
    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKey(Up))
        {
            y = 1;
        }

        if (Input.GetKey(Down))
        {
            y = -1;
        }

        if (Input.GetKeyUp(Up) || Input.GetKeyUp(Down))
        {
            y = 0;
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(0, y * speed);
    }
}
