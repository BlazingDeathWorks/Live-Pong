using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreWall : MonoBehaviour
{
    public ScoreManager scoreManager;
    public bool score1, score2;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (score1)
        {
            scoreManager.IncrementScore1();
            return;
        }
        if (score2)
        {
            scoreManager.IncrementScore2();
            return;
        }
    }
}
