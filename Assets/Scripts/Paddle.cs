using UnityEngine;

public class Paddle : MonoBehaviour
{
    public Rigidbody2D rb;
    private float movement;
    public float speed;
    public bool isPlayer1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayer1)
        {
            movement = Input.GetAxisRaw("Vertical");
        }
        else
        {
            movement = Input.GetAxisRaw("Vertical2");
        }
    }

    private void FixedUpdate()
    {
        rb.linearVelocityY = movement * speed;
    }

}
