using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuFunction : MonoBehaviour {

    public AudioSource buttonPress;

    public void PlayGame()
    {
        buttonPress.Play();
        SceneManager.LoadScene(2);
        RedirectToLevel.redirectToLevel = 3;
    }

    public void QuitGame()
    {
        buttonPress.Play();
        Application.Quit();
    }

    public void PlayCreds()
    {
        buttonPress.Play();
        SceneManager.LoadScene(4);
    }
}

