using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    private Object _mainScene;

    [SerializeField]
    private Object _creditScene;

    public void StartGame()
    { 
        SceneManager.LoadScene(_mainScene.name);
    }

    public void Credits()
    {
        SceneManager.LoadScene(_creditScene.name);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
