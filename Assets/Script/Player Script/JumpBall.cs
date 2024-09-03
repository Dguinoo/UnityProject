using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBall : MonoBehaviour
{
    public float bounceForce = 10f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Vector2 bounce = Vector2.up * bounceForce;
        rb.velocity = new Vector2(rb.velocity.x, 0);
        rb.AddForce(bounce, ForceMode2D.Impulse); // .Force .Impulse .Acceleration .VelocityChange
    }
}
