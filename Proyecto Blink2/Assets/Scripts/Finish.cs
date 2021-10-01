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

    private void openChest()
    {
        if (Input.GetKeyDown(KeyCode.E) && onChest && numGolpesAbrir > 0)
        {
            Player.player.HeroAction(costGolpesAbrir);
            numGolpesAbrir--;
            if (numGolpesAbrir == 1)
            {
                anim.SetTrigger("ChestOpening");
            }
            else if (numGolpesAbrir == 0)
            {
                LifeManager.lifeManager.GameOverForzado();
                //anim.SetTrigger("ChestOpen");
                //Destroy(gameObject);
                //SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
                //StartCoroutine(LoadScene());
            }
        }
    }

}
