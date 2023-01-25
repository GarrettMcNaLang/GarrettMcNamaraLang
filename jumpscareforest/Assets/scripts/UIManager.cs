using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject GameOverMenu;

    public GameObject GameCompletionMenu;

    public void enableGameCompletion()
    {
        GameCompletionMenu.SetActive(true);
    }



    public void enableGameOver()
    {
        GameOverMenu.SetActive(true);
    }
    private void OnEnable()
    {
        playerHealth.OnPlayerDeath += enableGameOver;
        GameComplete.gameComplete += enableGameCompletion;
    }

    private void OnDisable()
    {
        playerHealth.OnPlayerDeath -= enableGameOver;
        GameComplete.gameComplete -=enableGameCompletion;
    }
   
    public void RestartLevel()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
