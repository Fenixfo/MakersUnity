// Jair Duván Ayala Duarte
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
    
    // Close Game
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Quit");
        Application.Quit();
    }

}
