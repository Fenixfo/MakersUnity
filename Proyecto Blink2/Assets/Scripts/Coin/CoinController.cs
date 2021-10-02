// Jair Duván Ayala Duarte
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    AudioSource aSource;
    public AudioClip point;
    // Code setting for the sound of coins
    private void Start()
    {
        aSource = transform.parent.GetComponent<AudioSource>();
    }
    // Trigger to know at what point the coin is caught
    private void OnTriggerEnter2D(Collider2D collision)
    {
        aSource.PlayOneShot(point);
        Destroy(gameObject);
        Destroy(transform.parent.gameObject,1);
        ScoreManager.scoreManager.RaiseScore(1);
    }
}
