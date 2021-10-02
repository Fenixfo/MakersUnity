// Jair Duván Ayala Duarte
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneController : MonoBehaviour
{
    public Animator anim;
    public string sceneName;

    public static SceneController sceneController;

    public void Start()
    {
        sceneController = this;
    }

    // Read scene
    IEnumerator LoadScene()
    {
        anim.SetTrigger("end");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(sceneName);

    }
    // change scene
    public void SceneChange()
    {
        StartCoroutine(LoadScene());
    }
}
