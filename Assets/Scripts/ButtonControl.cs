using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonControl : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }

    public void Play()
    {
        SceneManager.LoadScene("LevelScene");
    }

    public void Restart()
    {
        Friends.gameRunning = true;
        Friends.lives = 3;
        Friends.score = 0;
        SceneManager.LoadScene(2);
    }

    public void Menu()
    {
        Friends.gameRunning = true;
        Friends.lives = 3;
        Friends.score = 0;
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }
}
