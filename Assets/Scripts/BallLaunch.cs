using UnityEngine;
// Suggestion: `using UnityEngine.WSA;` no se usa en este archivo. Lo mismo pasa con `Unity.VisualScripting` en GameTimeer.cs:1 y GoalZP1.cs:3, `System.Runtime.CompilerServices` en GoalZP1.cs:1, `System.Xml.Linq` en GoalZP2.cs:1 y PlayerOneMovement.cs:1, y `Unity.VectorGraphics` en UiMainMenu.cs:2.
// Son los que agrega el autocompletado sin que te des cuenta. Borralos todos.
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
        // Suggestion: xDirection se inicializa con un Random.Range que se descarta en la línea siguiente, porque el if vuelve a sortear. Lo mismo con yDirection en la línea 26.
        // Se resuelve en una línea: `float xDirection = Random.Range(0, 2) == 0 ? -1f : 1f;`
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
            // Warning: la velocidad se multiplica por 1.1 en cada choque contra Paddle o Limits y no hay ningún tope, así que crece de forma exponencial hasta que la pelota atraviesa los colliders.
            // Acotala con Vector2.ClampMagnitude(ballRB.linearVelocity * velocityMultiplier, maxSpeed) y serializá maxSpeed.
            ballRB.linearVelocity = velocityMultiplier * ballRB.linearVelocity;  
        }
    }
}
