using UnityEngine;

public class Goal : MonoBehaviour
{
    public bool isPlayer1Goal;
    public ScoreManager scoreManager;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ball")
        {
            if (isPlayer1Goal)
            {
                scoreManager.Player2Score();
            }
            else
            {
                scoreManager.Player1Score();
            }

        }
    }
}
