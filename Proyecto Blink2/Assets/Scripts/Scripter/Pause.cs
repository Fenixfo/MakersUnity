// Jair Duván Ayala Duarte
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{

    bool active;
    public Text textPause;

    // Start is called before the first frame update
    void Start()
    {
        textPause.enabled = false;
        SetChildren();
    }

    // Update is called once per frame
    void Update()
    {
        // See if the key pressed is "p"
        if (Input.GetKeyDown("p"))
        {
            Debug.Log(gameObject.name);
            active = !active;
            textPause.enabled = active;
            // Stop time
            Time.timeScale = (active) ? 0 : 1;
            SetChildren();
        }
    }
    // Continue with the execution of the game
    public void Resume()
    {
        active = false;
        textPause.enabled = active;
        // Stop time
        Time.timeScale = (active) ? 0 : 1;
        SetChildren();
    }
    // Modify the values of the pause screen to return to the menu
    public void Menu()
    {
        active = false;
        textPause.enabled = active;
        // Stop time
        Time.timeScale = (active) ? 0 : 1;
        SetChildren();
        SceneManager.LoadScene("MainMenu");
    }
    // Obtain the pause objects to display on the screen
    private void SetChildren()
    {
        textPause.transform.GetChild(0).gameObject.SetActive(active);
        textPause.transform.GetChild(1).gameObject.SetActive(active);
        textPause.transform.GetChild(2).gameObject.SetActive(active);
    }

}
