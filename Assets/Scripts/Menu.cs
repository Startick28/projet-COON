using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ShowSettings()
    {
        SceneManager.LoadScene("SettingsMenu");

    }

    public void ShowMenu()
    {
        SceneManager.LoadScene("Menu");

    }

    public void Quit()
    {
        Application.Quit();
    }
}
