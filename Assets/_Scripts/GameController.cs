using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    //public GameObject planet;
    public GameObject health;

   // public int numberOfPlanets;
   // public List<GameObject> planets;

    public int numberOfHealths;
    public List<GameObject> healths;

    // Start is called before the first frame update
    void Start()
    {
        //planets = new List<GameObject>();
        //for (int planetNum = 0; planetNum < numberOfPlanets; planetNum++)
       // {
        //    planets.Add(Instantiate(planet));
       // }
        //Instantiate(planet);
        healths = new List<GameObject>();
        for (int healthNum = 0; healthNum < numberOfHealths; healthNum++)
        {
            healths.Add(Instantiate(health));
        }
        Instantiate(health);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
