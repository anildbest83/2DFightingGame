using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int enemiesKilled = 0;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI HighScoreText;
    public TextMeshProUGUI gameOverScoreText;


    private void Start()
    {
        HighScoreText.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    private void Update()
    {
        scoreText.text = enemiesKilled.ToString();
        gameOverScoreText.text = enemiesKilled.ToString();

        if (enemiesKilled > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", enemiesKilled);
            HighScoreText.text = enemiesKilled.ToString();
        }

    }
}
