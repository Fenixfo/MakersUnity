// Jair Duván Ayala Duarte
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopController : MonoBehaviour
{

    AudioSource aSource;
    public AudioClip dying;
    public float lifeTime =0.3f;


    // Start is called before the first frame update
    void Start()
    {
        aSource = transform.parent.GetComponent<AudioSource>();
    }

    // Control to know when an enemy is killed by the player
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.name == "Hero")
        {
            // Change death animation 
            transform.parent.GetComponent<Animator>().SetBool("death", true);
            Destroy(transform.parent.gameObject, lifeTime);
            aSource.PlayOneShot(dying);

        }
    }

}
