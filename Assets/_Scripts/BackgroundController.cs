using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    public float verticalSpeed = 0.1f;
    public float resetPosition = 3.9f;
    public float resetPoint = -4.08f;
    // Start is called before the first frame update
    void Start()
    {
        //Reset();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        CheckBounds();
    }
    /// <summary>
    /// Moves background down
    /// </summary>
    void Move()
    {
        Vector2 newPositition = new Vector2(0.0f, verticalSpeed);
        Vector2 currentPosition = transform.position;

        currentPosition -= newPositition;
        transform.position = currentPosition;
    }
    /// <summary>
    /// Moves background to reset position
    /// </summary>
    void Reset()
    {
        transform.position = new Vector2(0.0f, resetPosition);
    }
    // move blackground back to reset point
    void CheckBounds()
    {
        if (transform.position.y <= resetPoint)
        {
            Reset();
        }
    }
}
