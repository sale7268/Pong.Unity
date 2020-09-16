using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Ball")]
    public GameObject ball;

    [Header("Player 1")]
    public GameObject player1Paddle;
    public GameObject player1Goal;

    [Header("Player 2")]
    public GameObject player2Paddle;
    public GameObject player2Goal;

    [Header("Score UI")]
    public GameObject Player1Text;
    public GameObject Player2Text;

    private int Player1Score = 0;
    private int Player2Score = 0;

    public void Player1Scored()
    {
        if (Player1Score < 11)
        {
            Player1Score++;
            Player1Text.GetComponent<TextMeshProUGUI>().text = Player1Score.ToString();
            Player1Text.GetComponent<TextMeshProUGUI>().color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f); ;
        }
        else
        {
            Debug.Log("GameOver!! Player 1 wins.");
            Player1Score = 0;
            Player1Text.GetComponent<TextMeshProUGUI>().text = Player1Score.ToString();
            Player2Score = 0;
            Player2Text.GetComponent<TextMeshProUGUI>().text = Player2Score.ToString();
        }
        ResetPosition();
    }

    public void Player2Scored()
    {
        if(Player2Score < 11)
        {
            Player2Score++;
            Player2Text.GetComponent<TextMeshProUGUI>().text = Player2Score.ToString();
            Player2Text.GetComponent<TextMeshProUGUI>().color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f); ;
        }
        else
        {
            Debug.Log("GameOver!! Player 2 wins.");
            Player2Score = 0;
            Player2Text.GetComponent<TextMeshProUGUI>().text = Player2Score.ToString();
            Player1Score = 0;
            Player1Text.GetComponent<TextMeshProUGUI>().text = Player1Score.ToString();
        }
        ResetPosition();
    }

    private void ResetPosition()
    {
        ball.GetComponent<Ball>().Reset();
        player1Paddle.GetComponent<Paddle>().Reset();
        player2Paddle.GetComponent<Paddle>().Reset();
    }
}
