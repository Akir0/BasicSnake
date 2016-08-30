using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class MenuRestartGameDie : MonoBehaviour
{
    [SerializeField]
    private Object _mainScene;

    [SerializeField]
    private Object _menuStart;

    public void RestartGame()
    {
        SceneManager.LoadScene(_mainScene.name);
    }

    public void AccessMainMenu()
    {
        SceneManager.LoadScene(_menuStart.name);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
