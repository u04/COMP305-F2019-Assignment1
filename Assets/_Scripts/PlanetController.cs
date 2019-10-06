using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetController : MonoBehaviour
{
    public float verticalSpeed = 0.1f;
    public float resetPosition = 7.74f;
    public float resetPoint = -8f;
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
    /// Moves planet down
    /// </summary>
    void Move()
    {
        Vector2 newPositition = new Vector2(0.0f, verticalSpeed);
        Vector2 currentPosition = transform.position;

        currentPosition -= newPositition;
        transform.position = currentPosition;
    }
    /// <summary>
    /// Moves planet to reset position
    /// </summary>
    void Reset()
    {
        float randomXPosition = Random.Range(-5.96f, 5.99f);
        transform.position = new Vector2(randomXPosition, resetPosition);
    }
    //move  planet back to reset point if it goes too far
    void CheckBounds()
    {
        if (transform.position.y <= resetPoint)
        {
            Reset();
        }
    }
}
