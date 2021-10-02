// Jair Duván Ayala Duarte
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RestartController : MonoBehaviour
{

    public static RestartController restartController;

    public Animator animScene;
    // Start is called before the first frame update
    void Start()
    {
        restartController = this;
    }

    // Trigger to restart the game
    private void OnTriggerEnter2D(Collider2D collision)
    {
        ResetGame();
    }
    // Method to restart the game
    public void ResetGame()
    {
        StartCoroutine(LoadScene());
    }

    // Load Scene
    IEnumerator LoadScene()
    {
        animScene.SetTrigger("end");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("MainMenu"/*"GameOver2"*/);
    }
}
