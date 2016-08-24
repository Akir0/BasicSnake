using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class MenuRestartGame : MonoBehaviour
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
