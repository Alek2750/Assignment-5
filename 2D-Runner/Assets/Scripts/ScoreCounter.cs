using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    
    public Text scoreText;

    public float scoreCount;

    public float pointsPerSecound;

    public bool scoreIncreasing;
    

    void Update()
    {
        if (scoreIncreasing)
        {
            scoreCount += pointsPerSecound * Time.deltaTime;
        }

        
        scoreText.text = "Score: " + Mathf.Round(scoreCount);

    }

    public void AddScore (int pointsToAdd)
    {
        scoreCount += pointsToAdd;
    }
}
