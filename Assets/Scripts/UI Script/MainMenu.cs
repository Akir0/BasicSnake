using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    private Object _mainScene;

    public void StartGame()
    { 
        SceneManager.LoadScene(_mainScene.name);
    }

    public void HighScore()
    {

    }

    public void Credits()
    {

    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
