// Jair Duván Ayala Duarte
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotController : MonoBehaviour
{
    Collider2D disparandoA = null;
    public float probabilidadDisparo = 1f;
    public GameObject bulletPrototype;
    Player ctr;

    // Trigger to know when the player enters the shooting area
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Hero") && disparandoA == null)
        {
            DecidaDisparar(collision);
        }
    }
    // Trigger to know when the player leaves the shooting area
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision==disparandoA)
        {
            disparandoA = null;
        }
    }
    // Shoot probability, default starts at 1 or 100%.
    void DecidaDisparar(Collider2D collision)
    {
        if (Random.value < probabilidadDisparo)
        {
            Disparar();
            disparandoA = collision;
        }
    }
    // method of shooting
    void Disparar()
    {
        GameObject bulletCopy = Instantiate(bulletPrototype);
        bulletCopy.transform.position = new Vector3(transform.parent.position.x, transform.parent.position.y,-1);
        bulletCopy.GetComponent<GunController>().direction = new Vector3(-transform.parent.localScale.x, 0, 0);
    }

}


