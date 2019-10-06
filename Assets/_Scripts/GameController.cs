using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    
    //public GameObject planet;
    public GameObject health;
    public AudioSource[] audioSources;

    [Header("Scoreboard")]
    [SerializeField]
    private int _health;
    [SerializeField]
    private int _score;
    public Text healthLable;
    public Text scoreLable;

    [Header("UI Control")]
    public GameObject startLable;
    public GameObject startButton;
    public GameObject endLable;

    public int Health
    {
        get
        {
            return _health;
        }

        set
        {
            _health = value;
            if(_health <= 0)
            {
                SceneManager.LoadScene("End");
            }
            healthLable.text = $"Health: {_health.ToString()}%";
        }
    }
    public int Score
    {
        get
        {
            return _score;
        }
        set
        {
            _score = value;
            scoreLable.text = "Score: " + _score.ToString();
        }
    }



    public int numberOfHealths;
    public List<GameObject> healths;

    // Start is called before the first frame update
    void Start()
    {

        Health = 100;
        Score = 0;

        
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

    //Event Handlers
    public void OnStartButtonClick()
    {
        SceneManager.LoadScene("Main");
    }
    
    
}
