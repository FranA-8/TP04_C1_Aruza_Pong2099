using UnityEngine;

public class ColorPadBall : MonoBehaviour
{
    private SpriteRenderer sr;
    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
           sr.color = new Color(Random.value, Random.value, Random.value);
        }
    }
}
