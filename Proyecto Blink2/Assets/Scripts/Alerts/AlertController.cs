// Jair Duván Ayala Duarte
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlertController : MonoBehaviour
{
    public static AlertController alertController;
    // Start is called before the first frame update
    void Start()
    {
        alertController = this;
    }
    // Start the alert controller
    public void AlertStart() {
        gameObject.GetComponent<Animator>().SetBool("start", true);
    }
    // End the alert controller
    public void AlertEnd()
    {
        gameObject.GetComponent<Animator>().SetBool("end", true);
    }
}
