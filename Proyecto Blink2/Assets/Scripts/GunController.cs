// Jair Duván Ayala Duarte
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{


    public float speed = 6;
    public float lifeTime = 2;
    public Vector3 direction = new Vector3(-1,0,0);

    Vector3 stepVector;
    Rigidbody2D rgb;

    // Start is called before the first frame update
    void Start()
    {
        // enemy firing
        Destroy(gameObject, lifeTime);
        rgb = GetComponent<Rigidbody2D>();
        stepVector = speed * direction.normalized;
    }
    
    // Update is called once per frame
    void Update()
    {
        rgb.velocity = stepVector;
    }
    // Destroy gun
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }

}
