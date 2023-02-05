using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Paddle player1, player2;
    public Puck puck;

    public void ResetGame()
    {
        player1.transform.position = new Vector2(-8, 0);
        player2.transform.position = new Vector2(8, 0);
        puck.ResetSelf();
    }

    public void ReloadScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
