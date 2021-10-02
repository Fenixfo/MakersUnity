// Jair Duván Ayala Duarte
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class FullScreenController : MonoBehaviour
{
    public Toggle toggle;
    public TMP_Dropdown resolutionDropdown;
    Resolution[] resolutions;
    // Start is called before the first frame update
    void Start()
    {
        // verification of screen resolutions
        if (Screen.fullScreen)
        {
            toggle.isOn = true;
        }
        else
        {
            toggle.isOn = false;
        }
        // verification of screen resolutions
        checkResolution();
    }
    // activate full screen
    public void FullScreenActivate(bool fullScreen)
    {
        Screen.fullScreen = fullScreen;
    }
    // verification of screen resolutions
    public void checkResolution()
    {
        resolutions = Screen.resolutions;
        resolutionDropdown.ClearOptions();
        List<string> options = new List<string>();
        int resolutionActual = 0;
        // read all screen resolutions
        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);
            // choose a new resolution
            if (Screen.fullScreen && resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
            {
                resolutionActual = i;
            }
        }
        // create a box with the resolutions
        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = resolutionActual;
        resolutionDropdown.RefreshShownValue();

        resolutionDropdown.value = PlayerPrefs.GetInt("numberResolution", 0);

    }
    // choose a new resolution
    public void changeResolution(int indexResolution)
    {
        PlayerPrefs.SetInt("numberResolution", resolutionDropdown.value);

        Resolution resolution = resolutions[indexResolution];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }



}
