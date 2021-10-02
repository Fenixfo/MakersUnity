// Jair Duván Ayala Duarte
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager scoreManager;
    
    float score = 0;
    public Text scoreText;

    // Adjustment of the score so that it is not lost when changing level
    private void Start()
    {
        if (scoreManager == null)
        {
            scoreManager = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Checking if the text exists in order to update on the screen
    void Update()
    {
        try
        {
            if (scoreText == null)
            {
                scoreText = GameObject.Find("TextScore").GetComponent<Text>();
                scoreText.text = score + "";
            }
        }
        catch (Exception e)
        {
            Debug.LogException(e);
        }
    }
    // Increase the score 
    public void RaiseScore(float s) 
    {
        score += s;
        scoreText.text = score+"";
    }
    // Change the score 
    public void SetScore(float s)
    {
        score = s;
        scoreText.text = score + "";
    }
}
