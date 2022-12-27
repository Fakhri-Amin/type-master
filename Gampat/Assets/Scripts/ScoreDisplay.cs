using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreDisplay : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private TMP_Text gameOverScoreText;
    [SerializeField] private TMP_Text highscoreText;

    private int score;
    private int highscore;

    // Start is called before the first frame update
    void Start()
    {
        UpdateScore();
        highscore = PlayerPrefs.GetInt("highscore", highscore);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddScore(int amount)
    {
        score += amount;
        UpdateScore();
        ShowGameOverScore();
    }

    private void UpdateScore()
    {
        scoreText.text = score.ToString();
    }

    private void UpdateHighscore()
    {
        if (score > highscore)
        {
            highscore = score;
            PlayerPrefs.SetInt("highscore", highscore);
        }

        highscoreText.text = "HIGHSCORE : " + highscore;
    }

    public void ShowGameOverScore()
    {
        gameOverScoreText.text = scoreText.text;
        UpdateHighscore();
    }
}
