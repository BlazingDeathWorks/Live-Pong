using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public GameManager gameManager;
    public Image winnerScreen;
    public Text scoreText1, scoreText2;
    public Text winnerText;
    public int winCondition = 7;
    private int score1, score2;

    private void CheckScore()
    {
        if (score1 >= winCondition)
        {
            winnerText.text = "Player 1 Wins";
            Time.timeScale = 0;
            winnerScreen.gameObject.SetActive(true);
        }

        if (score2 >= winCondition)
        {
            winnerText.text = "Player 2 Wins";
            Time.timeScale = 0;
            winnerScreen.gameObject.SetActive(true);
        }
    }

    public void IncrementScore1()
    {
        score1++;
        scoreText1.text = score1.ToString();
        CheckScore();
        gameManager.ResetGame();
    }

    public void IncrementScore2()
    {
        score2++;
        scoreText2.text = score2.ToString();
        CheckScore();
        gameManager.ResetGame();
    }
}
