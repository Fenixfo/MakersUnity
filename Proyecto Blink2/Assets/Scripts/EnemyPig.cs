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
        Vector2 v = new Vector2(vel, 0);
        rgb.velocity = v;
    }

    void Flip()
    {
        vel *= -1;
        transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
        /*var angles = transform.rotation.eulerAngles;
        angles.y += 180;
        transform.rotation = Quaternion.Euler(angles);
        */
        //transform.parent.SetPositionAndRotation(transform.parent.position,new Quaternion(transform.parent.rotation.x, transform.parent.rotation.y, transform.parent.rotation.z))
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.name.Equals("EnemyCollider"))
        {
            Flip();
        }
    }
}





    

    

    
