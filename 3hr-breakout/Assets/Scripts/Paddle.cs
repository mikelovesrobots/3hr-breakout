using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float boundaryLeft = -8f;
    public float boundaryRight = 8f;
    public float maxReflectionAngle = 60f; // Maximum reflection angle in degrees

    private void Update()
    {
        // Paddle movement
        float mouseX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x;
        Vector3 paddlePosition = transform.position;
        paddlePosition.x = Mathf.Clamp(mouseX, boundaryLeft, boundaryRight);
        transform.position = paddlePosition;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            var contact = collision.GetContact(0);
            ReflectBall(collision.gameObject, contact.point);
        }
    }

    private void ReflectBall(GameObject ball, Vector2 contactPoint)
    {
        Rigidbody2D ballRb = ball.GetComponent<Rigidbody2D>();

        // Calculate hit position relative to paddle center (-1 to 1)
        float hitPosition = (contactPoint.x - transform.position.x) / (GetComponent<Collider2D>().bounds.size.x / 2);

        // Calculate reflection angle
        float reflectionAngle = -hitPosition * maxReflectionAngle;

        // Calculate reflection direction
        Vector2 reflectionDirection = Quaternion.Euler(0, 0, reflectionAngle) * Vector2.up;

        // Apply new velocity
        ballRb.velocity = reflectionDirection;
    }
}