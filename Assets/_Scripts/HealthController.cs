using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    public float verticalSpeed = 0.005f;
    public float resetPosition = 5.56f;
    public float resetPoint = -5.53f;
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
        float randomXPosition = Random.Range(-8.42f, 8.36f);
        transform.position = new Vector2(randomXPosition, resetPosition);
    }

    void CheckBounds()
    {
        if (transform.position.y <= resetPoint)
        {
            Reset();
        }
    }
}
