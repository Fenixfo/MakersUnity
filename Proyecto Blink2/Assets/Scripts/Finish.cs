// Jair Duván Ayala Duarte
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    
    public int numGolpesAbrir = 2;
    public int costGolpesAbrir = 1;
    public static Finish finish;
    Animator anim;
    public Animator animScene;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        openChest();
    }

    bool onChest = false;
    // verify collision with the hero
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.name.Equals("Hero"))
        {
            onChest = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Hero"))
        {
            onChest = false;
        }
    }
    // Method for opening the chest
    private void openChest()
    {
        // Verify if the key pressed is "E"
        if (Input.GetKeyDown(KeyCode.E) && onChest && numGolpesAbrir > 0)
        {
            Player.player.HeroAction(costGolpesAbrir);
            numGolpesAbrir--;
            // Check if the chest is opening and adjust the animation
            if (numGolpesAbrir == 1)
            {
                anim.SetTrigger("ChestOpening");
            }
            else if (numGolpesAbrir == 0)
            {
                LifeManager.lifeManager.GameOverForzado();
            }
        }
    }

}
