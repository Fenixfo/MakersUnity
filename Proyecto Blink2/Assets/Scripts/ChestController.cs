// Jair Duván Ayala Duarte
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ChestController : MonoBehaviour
{
    public int numGolpesAbrir = 2;
    public int costGolpesAbrir = 1;

    Animator anim;
    public Animator animScene;
    // Start is called before the first frame update
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
    // Method to validate when the character comes in contact with the chest
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name.Equals("Hero"))
        {
            onChest = true;
        }
    }
    // check if the player has left the range of the chest
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Hero"))
        {
            onChest = false;
        }
    }
    // Open Chest
    private void openChest()
    {
        // check if the E key is pressed
        if (Input.GetKeyDown(KeyCode.E) && onChest && numGolpesAbrir>0) 
        {
            Player.player.HeroAction(costGolpesAbrir);
            numGolpesAbrir--;
            // Count the number of times E was pressed to change animation or level change
            if (numGolpesAbrir == 1)
            {
                anim.SetTrigger("ChestOpening");
            }
            else if (numGolpesAbrir == 0)
            {
                anim.SetTrigger("ChestOpen");
                StartCoroutine(LoadScene());
            }
        }
    }
    // Load Scene
    IEnumerator LoadScene()
    {
        animScene.SetTrigger("end");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(gameObject.name);
    }
}
