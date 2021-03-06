// Jair Duván Ayala Duarte
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class QualityController : MonoBehaviour
{
    public TMP_Dropdown dropdown;
    public int quality;

    // Start is called before the first frame update
    void Start()
    {
        quality = PlayerPrefs.GetInt("qualityNumber", 3);
        dropdown.value = quality;
        QualitySetting();
    }
    // modification of the image quality
    public void QualitySetting()
    {
        QualitySettings.SetQualityLevel(dropdown.value);
        PlayerPrefs.SetInt("qualityNumber", dropdown.value);
        quality = dropdown.value;
    }
}
