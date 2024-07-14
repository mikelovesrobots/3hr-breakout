using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float initialForce = 2f;

    private void Start()
    {
        StartMoving();
    }

    public void StartMoving()
    {
        var randomDirection = new Vector2(Random.Range(-1f, 1f), 1).normalized;
        GetComponent<Rigidbody2D>().velocity = randomDirection * 2f;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("BottomWall"))
        {
            Destroy(gameObject);
        }
    }
}
