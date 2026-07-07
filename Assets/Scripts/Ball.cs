using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D rb;

    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        LaunchBall();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LaunchBall()
    {
        rb.linearVelocity = Vector2.zero;
        Invoke("RandomLaunch", 1.5f);
    }
    private void RandomLaunch()
    {
        int randomX = Random.Range(0, 2) == 0 ? -1 : 1;
        int randomY = Random.Range(0, 2) == 0 ? -1 : 1;
        rb.linearVelocity = new Vector2(randomX, randomY) * speed;
    }

}
