using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public float boundaryLeft = -8f;
    public float boundaryRight = 8f;

    void Update()
    {
        var mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        var paddlePosition = new Vector3(mousePosition.x, transform.position.y, 0);
        paddlePosition.x = Mathf.Clamp(paddlePosition.x, boundaryLeft, boundaryRight);
        transform.position = paddlePosition;
    }
}