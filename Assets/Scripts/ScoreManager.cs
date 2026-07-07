using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public GameObject ball;
    public TMP_Text player1scoreText;
    public TMP_Text player2scoreText;
    public TMP_Text PlayerWinText;
    public int maxScoreToWin;
    public Button RestartBtn;
    private float player1Score;
    private float player2Score;
    private Ball ballscript;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ballscript = ball.GetComponent<Ball>();
    }

    private void RestBall()
    {
        ball.transform.position = Vector2.zero;
        ballscript.LaunchBall();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Player1Score()
    {
        player1Score++;
        player1scoreText.text = player1Score.ToString();
        CheckWinner();
        Debug.Log("Player 1 Has Scored");
        RestBall();
    }

    public void Player2Score()
    {
        player2Score++;
        player2scoreText.text = player2Score.ToString();
        CheckWinner() ;
        Debug.Log("Player 2 Has Scored");
        RestBall();
    }

    void CheckWinner()
    {
        if(maxScoreToWin == player1Score)
        {
            Debug.Log("Player 1 Wins!");
            ball.SetActive(false);
            PlayerWinText.text = "Player 1 Wins!";
            PlayerWinText.gameObject.SetActive(true);
            RestartBtn.gameObject.SetActive(true);
        }
        else if(maxScoreToWin == player2Score)
        {
            Debug.Log("Player 2 Wins!");
            ball.SetActive(false);
            PlayerWinText.text = "Player 2 Wins!";
            PlayerWinText.gameObject.SetActive(true);
            RestartBtn.gameObject.SetActive(true);
        }
    }
}
