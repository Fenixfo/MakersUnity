// Jair Duván Ayala Duarte
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlertCollisionController : MonoBehaviour
{
    public GameObject alert;
    // Start the alert collision controller
    private void OnTriggerEnter2D(Collider2D collision)
    {
        alert.GetComponent<Animator>().SetBool("start", true);
    }
    // End the alert collision controller
    private void OnTriggerExit2D(Collider2D collision)
    {
        alert.GetComponent<Animator>().SetBool("end", true);
    }

}
