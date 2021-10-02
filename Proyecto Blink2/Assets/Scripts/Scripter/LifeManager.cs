// Jair Duván Ayala Duarte
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LifeManager : MonoBehaviour
{

    public static LifeManager lifeManager;

    float life = 100;
    public Text textBlink;
    public Slider slider;
    // Verification of the existence of the life object
    private void Start()
    {
        if (lifeManager == null)
        {
            lifeManager = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
        }
    }


    void Update()
    {
        try {
            // Search for the test object to show life
            if (textBlink == null)
            {
                textBlink = GameObject.Find("TextBlink").GetComponent<Text>();
                textBlink.text = life + "";
            }
            // Search for the slider object to show life
            if (slider == null)
            {
                slider = GameObject.Find("SliderBlink").GetComponent<Slider>();
                slider.value = life;
                slider.value = life;
                textBlink.text = slider.value.ToString();
            }
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }
    }
    // Method for lowering player life
    public void LowerLife(float s)
    {
        life -= s;
        slider.value -= s;
        textBlink.text = slider.value.ToString();
        // If the player dies the end of game scene is loaded.
        if (life <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
        }
    }
    // Modify the player's life
    public void SetLife(float newLife)
    {
        life = newLife;
        slider.value = life;
        textBlink.text = slider.value.ToString();
        // If the player dies the end of game scene is loaded.
        if (life <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
        }
    }
    // Forzar fin de juego debido a un error de la carga de la pestaña de agradecimiento
    public void GameOverForzado() {
        Destroy(gameObject);
        SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
    }


    



}
