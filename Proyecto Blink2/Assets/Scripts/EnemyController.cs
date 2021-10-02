// Jair Duván Ayala Duarte
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float vel = 1f;
    Rigidbody2D rgb;
    public float energy = 100;

    // Start is called before the first frame update
    void Start()
    {
        rgb = gameObject.GetComponent<Rigidbody2D>();

    }
    // enemy speed adjustment
    void FixedUpdate()
    {
        Vector2 v = new Vector2(0, vel);
        rgb.velocity = v;
    }
    // collision check
    void OnTriggerEnter2D(Collider2D collider)
    {
        // verify whether the enemy is in the upper or lower zone
        if (collider.gameObject.name.Equals("EnemyColliderTop") || collider.gameObject.name.Equals("EnemyColliderBottom"))
        {
            Flip();
        }
    }
    // up or down
    void Flip() 
    {
        vel *= -1;
    }
}
