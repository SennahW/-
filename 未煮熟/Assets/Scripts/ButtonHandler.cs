using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonHandler : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(2);
    }

    public void Recipes()
    {
        SceneManager.LoadScene(1);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
    
    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Exit");
    }
}
