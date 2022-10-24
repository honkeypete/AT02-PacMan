using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    public void QuitToDesktop()
    {
        Application.Quit();
    }

    public void AT02Pacman()
    {
        SceneManager.LoadScene(0);
    }

    public void GameOver()
    {
        SceneManager.LoadScene(1);
    }

    public void YouWin()
    {
        SceneManager.LoadScene(2);
    }
}
