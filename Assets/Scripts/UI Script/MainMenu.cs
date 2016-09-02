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
        SceneManager.LoadScene("2. MainSceneSnakeGame");
    }

    public void Credits()
    {
        SceneManager.LoadScene("4. Credits");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
