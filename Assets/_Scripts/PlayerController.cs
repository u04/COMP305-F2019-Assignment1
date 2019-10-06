using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float maxSpeed = 0.001f;
    public float minSpeed = 0.001f;

    public GameController gameController;

    


    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        Move();
        CheckBounds();
    }

    /// <summary>
    /// moves the player depending on what the player inputs
    /// </summary>
    public void Move()
    {
        Vector2 newPosition = transform.position;
        if (Input.GetAxis("Horizontal") > 0.0f)
        {
            newPosition += new Vector2(maxSpeed, 0.0f);
        }
        if (Input.GetAxis("Horizontal") < 0.0f)
        {
            newPosition += new Vector2(minSpeed, 0.0f);
        }
        transform.position = newPosition;
    }
    /// <summary>
    /// Keeps the player on screen by not allowing the player to go too far to the left or right
    /// </summary>
    public void CheckBounds()
    {
        if (transform.position.x > 8.16f)
        {
            transform.position = new Vector2(8.16f, transform.position.y);
        }

        if (transform.position.x < -8.1f)
        {
            transform.position = new Vector2(-8.1f, transform.position.y);
        }
    }
    /// <summary>
    /// does its thing if it touches the artwork in the game tagged "Planet" or "Health"
    /// </summary>
    /// <param name="collision"></param>
    void OnTriggerEnter2D(Collider2D collision)
    {
        
        switch (collision.gameObject.tag)
        {
            case "Planet":
                // Debug.Log("hit planet");
                gameController.audioSources[0].Stop();
                gameController.audioSources[2].Play();
                gameController.Health -= 25;


                break;
            case "Health":
                // Debug.Log("hit health");
                gameController.audioSources[0].Stop();
                gameController.audioSources[1].Play();
                gameController.Score += 1;
 

                break;
        }
    }
}
