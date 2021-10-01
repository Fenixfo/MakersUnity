using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOverController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReturnMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Level1");
    }

    public void GoLevel1()
    {
        SceneManager.LoadScene("Level1");
        RestartValues.restartValues.ResetValues(90,0);
    }

    public void GoLevel2()
    {
        SceneManager.LoadScene("Level2");
        RestartValues.restartValues.ResetValues(90, 0);
    }

    public void GoLevel3()
    {
        SceneManager.LoadScene("Level3");
        RestartValues.restartValues.ResetValues(90, 0);
    }

    public void GoLevel4()
    {
        SceneManager.LoadScene("Level4");
        RestartValues.restartValues.ResetValues(90, 0);
    }

    public void GoLevel5()
    {
        SceneManager.LoadScene("Level5");
        RestartValues.restartValues.ResetValues(90, 0);
    }

    public void GoLevel6()
    {
        SceneManager.LoadScene("Level6");
        RestartValues.restartValues.ResetValues(90, 0);
    }

    public void GoLevel7()
    {
        SceneManager.LoadScene("Level7");
        RestartValues.restartValues.ResetValues(90, 0);
    }

    public void GoLevel8()
    {
        SceneManager.LoadScene("Level8");
        RestartValues.restartValues.ResetValues(90, 0);
    }

    public void GoLevel9()
    {
        SceneManager.LoadScene("Level9");
        RestartValues.restartValues.ResetValues(90, 0);
    }

    public void GoLevel10()
    {
        SceneManager.LoadScene("Level10");
        RestartValues.restartValues.ResetValues(90, 0);
    }

}
