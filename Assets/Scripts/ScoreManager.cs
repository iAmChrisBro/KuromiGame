using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    private TMP_Text scoreCount, livesCount;
    public TMP_Text highScore;

    void Start()
    {
        scoreCount = GameObject.Find("Score Counter").GetComponent<TMP_Text>();
        livesCount = GameObject.Find("Lives Counter").GetComponent<TMP_Text>();
    }

    void Update()
    {
        UpdateHighScore();

        if (Friends.lives == -1)
            livesCount.text = "0";
        else
        {
            scoreCount.text = Friends.score.ToString();
            livesCount.text = Friends.lives.ToString();
        }
    }

    private void UpdateHighScore()
    {
        if (Friends.score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", Friends.score);
            PlayerPrefs.Save();
        }
        highScore.text = $"{PlayerPrefs.GetInt("HighScore")}";
    }
}