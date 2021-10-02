// Jair Duván Ayala Duarte
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOverController : MonoBehaviour
{
    // load main scene
    public void ReturnMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    // get out of the game
    public void ExitGame()
    {
        Application.Quit();
    }
    // load Level1 scene
    public void StartGame()
    {
        SceneManager.LoadScene("Level1");
    }
    // load Level1 scene
    public void GoLevel1()
    {
        SceneManager.LoadScene("Level1");
        RestartValues.restartValues.ResetValues(90,0);
    }
    // load Level2 scene
    public void GoLevel2()
    {
        SceneManager.LoadScene("Level2");
        RestartValues.restartValues.ResetValues(90, 0);
    }
    // load Level3 scene
    public void GoLevel3()
    {
        SceneManager.LoadScene("Level3");
        RestartValues.restartValues.ResetValues(90, 0);
    }
    // load Level4 scene
    public void GoLevel4()
    {
        SceneManager.LoadScene("Level4");
        RestartValues.restartValues.ResetValues(90, 0);
    }
    // load Level5 scene
    public void GoLevel5()
    {
        SceneManager.LoadScene("Level5");
        RestartValues.restartValues.ResetValues(90, 0);
    }
    // load Level6 scene
    public void GoLevel6()
    {
        SceneManager.LoadScene("Level6");
        RestartValues.restartValues.ResetValues(90, 0);
    }
    // load Level7 scene
    public void GoLevel7()
    {
        SceneManager.LoadScene("Level7");
        RestartValues.restartValues.ResetValues(90, 0);
    }
    // load Level8 scene
    public void GoLevel8()
    {
        SceneManager.LoadScene("Level8");
        RestartValues.restartValues.ResetValues(90, 0);
    }
    // load Level9 scene
    public void GoLevel9()
    {
        SceneManager.LoadScene("Level9");
        RestartValues.restartValues.ResetValues(90, 0);
    }
    // load Level10 scene
    public void GoLevel10()
    {
        SceneManager.LoadScene("Level10");
        RestartValues.restartValues.ResetValues(90, 0);
    }

}
