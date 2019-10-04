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

    void OnTriggerEnter2D(Collider2D collision)
    {
        
        switch (collision.gameObject.tag)
        {
            case "Planet":
                // Debug.Log("hit planet");
                gameController.audioSources[0].Stop();
                gameController.audioSources[2].Play();



                break;
            case "Health":
                // Debug.Log("hit health");
                gameController.audioSources[0].Stop();
                gameController.audioSources[1].Play();
 

                break;
        }
    }
}
