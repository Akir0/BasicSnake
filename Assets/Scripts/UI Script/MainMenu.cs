﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("2. MainSceneSnakeGame");
    }

    public void HighScore()
    {

    }

    public void Credits()
    {

    }
}
