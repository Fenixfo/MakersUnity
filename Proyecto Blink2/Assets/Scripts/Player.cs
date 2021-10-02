// Jair Duván Ayala Duarte
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Player : MonoBehaviour
{
    public static Player player;
    public float vel = -1f;
    Rigidbody2D rgb;
    Animator anim;
    bool right = true;
    bool caminando = false;
    bool shooting = false;

    bool canJump = false;
    bool doubleJump = false;
    bool isDoubleJump = false;
    bool isAlive = true;

    bool inTheEarth = false;

    public Slider slider;
    public Text text;

    public float velScale = 5;
    public float gunDamage = 5;
    public float topDamage = 5;
    public float endDamage = 10;
    
    public float forceDamage = 20000;

    AudioSource aSource;
    public AudioClip jumping;
    public AudioClip damaging;
    public AudioClip dying;

    SpriteRenderer rend;

    // Start is called before the first frame update
    void Start()
    {
        player = this;
        rgb = gameObject.GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        rend = GetComponent<SpriteRenderer>();
        aSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Shoot();
        Jump();
    }


    void FixedUpdate()
    {
        Mov();
    }
    // character movement
    void Mov() 
    {
        // set initial speed
        float v = Input.GetAxis("Horizontal");
        Vector2 vel = new Vector2(0, rgb.velocity.y);
        v *= velScale;
        vel.x = v;
        rgb.velocity = vel;
        // check if the character is moving
        if (right && v < 0)
        {
            right = false;
            Flip();
        }
        else if (!right && v > 0)
        {
            right = true;
            Flip();
        }
        // check if the character is moving
        if (rgb.velocity.x == 0)
        {
            // check if the character is falling
            if (!(rgb.velocity.y > 0.05 || rgb.velocity.y < -0.05))
            {
                gameObject.GetComponent<Animator>().SetBool("stop", true);
                gameObject.GetComponent<Animator>().SetBool("caminando", false);
                caminando = false;
            }
        }
        else if (!(rgb.velocity.x == 0) && !caminando){
            // check if the character is falling
            if (!(rgb.velocity.y > 0.05 || rgb.velocity.y < -0.05))
            {
                gameObject.GetComponent<Animator>().SetBool("stop", false);
                gameObject.GetComponent<Animator>().SetBool("caminando", true);
                caminando = true;
            }
        }
    }
    // to turn the character
    void Flip()
    {
        var s = transform.localScale;
        s.x *= -1;
        transform.localScale = s;
    }
    // method of firing
    void Shoot() 
    {
        if (Input.GetKeyDown(KeyCode.F)) 
        {
            gameObject.GetComponent<Animator>().SetBool("shooting", true);
            Action();
        }
        
    }
    // verification of the animation for the main character
    void Action() 
    {
        // check if the character is moving
        if (rgb.velocity.x != 0)
        {
            // check if the character is falling
            if (!(rgb.velocity.y > 0.1 || rgb.velocity.y < -0.1))
            {
                gameObject.GetComponent<Animator>().SetBool("caminando", true);
            }
            
        }
        else 
        {
            // check if the character is falling
            if (!(rgb.velocity.y > 0.1 || rgb.velocity.y < -0.1))
            {
                gameObject.GetComponent<Animator>().SetBool("stop", true);
            }
        }
    }
    // jumping method 
    void Jump()
    {
        Vector2 vel = new Vector2(rgb.velocity.x, rgb.velocity.y);
        vel.y = velScale;
        // verify if the "w" or "up" keys are pressed 
        if ((Input.GetKeyDown("up") || Input.GetKeyDown("w")) && canJump)
        {
            canJump = false;
            aSource.PlayOneShot(jumping);
            rgb.velocity = vel;
            gameObject.GetComponent<Animator>().SetBool("saltando", true);
        }
        // verify if the "w" or "up" keys are pressed 
        if ((Input.GetKeyDown("up") || Input.GetKeyDown("w")) && doubleJump)
        {
            canJump = false;
            aSource.PlayOneShot(jumping);
            rgb.velocity = vel;
            doubleJump = false;
            gameObject.GetComponent<Animator>().SetBool("saltando", true);
        }
        rgb.transform.rotation = Quaternion.Euler(0, 0, 0);
    }
    // method to know if the character dies
    void Death()
    {
        // check if the value is 0 or less
        if (slider.value <= 0 && isAlive) 
        {
            isAlive = false;
            gameObject.GetComponent<Animator>().SetBool("color2", true);
        }
    }
    // check if the player is on the ground 
    private void OnCollisionExit2D(Collision2D collision)
    {
        // tag verification 
        if (collision.transform.tag == "Grownd")
        {
            if (isDoubleJump)
            {
                doubleJump = true;
            }
            
        }               
    }
    // Objects in collision
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // tag verification with "Grownd"
        if (collision.transform.tag == "Grownd")
        {
            doubleJump = false;
            canJump = true;
            // check if it is in motion
            if ((rgb.velocity.x > 0 || rgb.velocity.x < -0.01))
            {
                gameObject.GetComponent<Animator>().SetBool("caminando", true);
                caminando = true;
            }
        }
        // tag verification with "GunLevel1"
        if (collision.transform.tag == "GunLevel1")
        {
            HeroDamage(gunDamage);
        }
        // tag verification with "EnemyTopBad"
        if (collision.transform.tag == "EnemyTopBad")
        {
            Vector2 vel = new Vector2(rgb.velocity.x, rgb.velocity.y);
            vel.y = 3f;
            rgb.velocity = vel;
            HeroDamage(topDamage);
        }

    }
    // Objects in collision
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // tag verification with "EnemyTop"
        if (collision.transform.tag == "EnemyTop")
        {
            Vector2 vel = new Vector2(rgb.velocity.x, rgb.velocity.y);
            vel.y = 3f;
            rgb.velocity = vel;
        }
        // tag verification with "EnemyTopBad"
        if (collision.transform.tag == "EnemyTopBad")
        {
            Vector2 vel = new Vector2(rgb.velocity.x, rgb.velocity.y);
            vel.y = 6f;
            rgb.velocity = vel;
            HeroDamage(topDamage);
        }
        // tag verification with "EnemyRightBad"
        if (collision.transform.tag == "EnemyRightBad")
        {
            HeroDamage(topDamage);
        }
        // tag verification with "EnemyLeftBad"
        if (collision.transform.tag == "EnemyLeftBad")
        {
            HeroDamage(topDamage);
        }
        // tag verification with "EnemyBottomBad"
        if (collision.transform.tag == "EnemyBottomBad")
        {
            HeroDamage(topDamage);
        }
    }

    // method of generating damage
    public void HeroDamage(float damage)
    {
        LifeManager.lifeManager.LowerLife(damage);
        gameObject.GetComponent<Animator>().SetBool("color2", true);
        aSource.PlayOneShot(damaging);
        Death();
    }
    // method for lowering life
    public void HeroAction(float damage)
    {
        LifeManager.lifeManager.LowerLife(damage);
        Death();
    }
    // reset spawn level
    public void Teleport(float x,float y, float z)
    {
        gameObject.transform.position = new Vector3(x, y, z);        
    }


}
