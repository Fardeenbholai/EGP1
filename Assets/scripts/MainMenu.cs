using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);//eerst volgende scene wordt geladen na het drukken van play in de main menu.
    }

    public void Quitgame()
    {
        Debug.Log("Game has stopped");//wanneer op quit wordt gedrukt sluit de applicatie af.
        Application.Quit();
    }
}
