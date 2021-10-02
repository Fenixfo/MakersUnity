// Jair Duván Ayala Duarte
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BrightnessController : MonoBehaviour
{
    public Slider sliderBrightness;
    public float sliderValue;
    public Image panelBrightness;

    
    void Start()
    {
        // Controls the brightness, default starts at 0.5 or 50% transparency.
        sliderBrightness.value = PlayerPrefs.GetFloat("brillo", 0.5f);
        panelBrightness.color = new Color(panelBrightness.color.r, panelBrightness.color.g, panelBrightness.color.b, sliderBrightness.value);
    }

    // Method to modify brightness
    public void ChangeSlider(float valor)
    {
        sliderValue = valor;
        // In PlayerPrefs the configurations are saved so that when the game is run again they are not restarted.
        PlayerPrefs.SetFloat("brillo", sliderValue);
        panelBrightness.color = new Color(panelBrightness.color.r, panelBrightness.color.g, panelBrightness.color.b, sliderBrightness.value);
    }

}
