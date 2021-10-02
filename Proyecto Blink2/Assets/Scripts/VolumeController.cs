// Jair Duván Ayala Duarte
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class VolumeController : MonoBehaviour
{
    public Slider sliderVolume;
    public float sliderValue;
    public Image imageMute;

    // Start is called before the first frame update
    void Start()
    {
        // Controls the volumen, default starts at 0.5 or 50% transparency
        sliderVolume.value = PlayerPrefs.GetFloat("volumeAudio", 0.5f);
        AudioListener.volume = sliderVolume.value;
        isMute();
        
    }

    // In PlayerPrefs the configurations are saved so that when the game is run again they are not restarted
    public void ChangeSlider(float valor)
    {
        sliderValue = valor;
        PlayerPrefs.SetFloat("volumeAudio", sliderValue);
        AudioListener.volume = sliderVolume.value;
        isMute();
    }

    // An image is configured to show if the volume is at zero
    public void isMute()
    {
        if (sliderValue == 0)
        {
            imageMute.enabled = true;
        }
        else 
        {
            imageMute.enabled = false;
        }
    }
}
