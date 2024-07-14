using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float boundaryLeft = -8f;
    public float boundaryRight = 8f;
    public float paddleImpactForce = 100f;

    void Update()
    {
        var mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        var paddlePosition = new Vector3(mousePosition.x, transform.position.y, 0);
        paddlePosition.x = Mathf.Clamp(paddlePosition.x, boundaryLeft, boundaryRight);
        transform.position = paddlePosition;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            float paddleCenter = transform.position.x;
            float contactPoint = collision.GetContact(0).point.x;
            float offset = contactPoint - paddleCenter;

            var force = new Vector2(offset * paddleImpactForce, collision.rigidbody.velocity.y).normalized * paddleImpactForce;
            collision.rigidbody.AddForce(force);
        }
    }
}