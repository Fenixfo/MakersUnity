// Jair Duván Ayala Duarte
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartValues : MonoBehaviour
{

    public float life=100;
    public float points = 0;
    bool reset = true;

    public static RestartValues restartValues;

    // Start is called before the first frame update
    void Start()
    {
        restartValues = this;
    }

    // Update is called once per frame
    void Update()
    {
        // Resetting life values 
        if (reset)
        {
            ResetValues(life, points);
            reset = false;
        }
        
    }
    // Reset life values with input values
    public void ResetValues(float life, float points)
    {
        LifeManager.lifeManager.SetLife(life);
        ScoreManager.scoreManager.SetScore(points);
    }
    // Reset life values to initial values
    public void ResetValues()
    {
        LifeManager.lifeManager.SetLife(life);
        ScoreManager.scoreManager.SetScore(points);
    }

}
