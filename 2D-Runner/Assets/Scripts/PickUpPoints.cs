using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpPoints : MonoBehaviour
{
    public int scoreToGive;

    private ScoreCounter theScoreCounter;

    // Start is called before the first frame update
    void Start()
    {
        theScoreCounter = FindObjectOfType<ScoreCounter>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            theScoreCounter.AddScore(scoreToGive);
            
        }
    }
}
