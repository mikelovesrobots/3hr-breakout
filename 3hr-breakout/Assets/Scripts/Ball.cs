using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D rb;
    public float currentSpeed = 4f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        StartMoving();
    }

    private void FixedUpdate()
    {
        AdjustVelocityIfNecessary();
    }

    public void StartMoving()
    {
        var randomDirection = new Vector2(Random.Range(-1f, 1f), 1).normalized;
        rb.velocity = randomDirection * currentSpeed;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("BottomWall"))
        {
            Destroy(gameObject);
        }
    }

    private void AdjustVelocityIfNecessary()
    {
        rb.velocity = rb.velocity.normalized * currentSpeed;
    }
}
