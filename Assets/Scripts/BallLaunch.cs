using UnityEngine;
using UnityEngine.WSA;

public class BallLaunch : MonoBehaviour
{
    [SerializeField] private float Velocity = 300;
    [SerializeField] private float velocityMultiplier = 1.1f;
    private Rigidbody2D ballRB;
    void Start()
    {
        ballRB = GetComponent<Rigidbody2D>();
        Launch();
    }

    public void Launch()
    {
        float xDirection = Random.Range(0, 2);
            if (Random.Range(0, 2) == 0)
        {
            xDirection = -1;
        }
        else
        {
            xDirection = 1;
        }
        float yDirection = Random.Range(0, 2);
            if (Random.Range(0, 2) == 0)
        {
            yDirection = -1;
        }
        else
        {
            yDirection = 1;
        }

        ballRB.AddForce(new Vector2(xDirection, yDirection) * Velocity);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Paddle") || collision.gameObject.CompareTag("Limits"))
        {
            ballRB.linearVelocity = velocityMultiplier * ballRB.linearVelocity;  
        }
    }
}
