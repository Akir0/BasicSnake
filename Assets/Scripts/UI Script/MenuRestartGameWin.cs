using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class MenuRestartGameWin : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene("2. MainSceneSnakeGame");
    }

    public void AccessMainMenu()
    {
        SceneManager.LoadScene("1. MenuStart");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
