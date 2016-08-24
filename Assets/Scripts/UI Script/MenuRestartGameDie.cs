using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class MenuRestartGameDie : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene("2. MainSceneSnakeGame");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
