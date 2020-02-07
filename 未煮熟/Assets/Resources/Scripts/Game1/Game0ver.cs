using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Game0ver : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject myGameOverUI;

    void Update()
    {
      // if(//om spelaren förlorar)
        {

        }
    }

    public void PausedGame()
    {
        myGameOverUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void MainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }
}
