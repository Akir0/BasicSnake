using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class ScriptButtonBackMenu : MonoBehaviour
{
    [SerializeField]
    private Object _mainMenu;

    public void BackToMenu()
    {
        SceneManager.LoadScene("1. MenuStart");
    }
}
