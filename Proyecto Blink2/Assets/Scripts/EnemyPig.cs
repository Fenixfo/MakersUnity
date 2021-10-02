// Jair Duván Ayala Duarte
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPig : MonoBehaviour
{
    public float vel = 1f;
    Rigidbody2D rgb;
    // Start is called before the first frame update
    void Start()
    {
        rgb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // pig speed adjustment
        Vector2 v = new Vector2(vel, 0);
        rgb.velocity = v;
    }
    // turning the enemy around
    void Flip()
    {
        // change of direction of the pig
        vel *= -1;
        transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
    }
    // collision check with invisible barriers
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.name.Equals("EnemyCollider"))
        {
            Flip();
        }
    }
}





    

    

    
