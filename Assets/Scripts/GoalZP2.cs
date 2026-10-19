using System.Xml.Linq;
using TMPro;
// Error: `using UnityEditor;` en un script de runtime. El namespace UnityEditor no existe fuera del editor, así que el proyecto compila con Play pero falla al hacer Build.
// Borrá la línea. Es el mismo problema que arrastrás desde el TP02 y el TP03.
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

// Suggestion: GoalZP1 y GoalZP2 son la misma clase con dos líneas cambiadas. Son 58 líneas duplicadas, y ya se nota en que el bug del timer hay que arreglarlo dos veces.
// Dejá una sola clase con un campo [SerializeField] private bool scoresForPlayerOne y usala en los dos arcos.
public class GoalZP2 : MonoBehaviour
{
    [SerializeField] private GameOptions gameOptions;
    [SerializeField] private TMP_Text scoreP1;
    [SerializeField] private TMP_Text scoreP2;

    [SerializeField] private GameObject playerOne;
    [SerializeField] private GameObject playerTwo;
    [SerializeField] private GameObject ball;

    private int goalPlayerOne = 0;
    private int goalPlayerTwo = 0;
    private float victoryPoints = 3;
    private float timer = 20f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            scoreP1.text = (++goalPlayerOne).ToString("f0");
            playerOne.transform.position = new Vector3(-6.0f, 0f, -3f);
            playerTwo.transform.position = new Vector3(6.0f, 0f, -3f);
            ball.transform.position = new Vector3(0f, 0f, -3f);

        }

    }
    private void Start()
    {
        victoryPoints = gameOptions.victoryPoints;
    }
    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            // Bug: la condición es `ball.transform.position.x < 0`, exactamente la misma que en GoalZP1.cs:41, pero acá el punto va para el jugador 1.
            // O sea que cuando se cumple el tiempo y la pelota está a la izquierda, los dos scripts cobran gol a la vez y cada jugador suma un punto. Para este arco la condición tiene que ser `> 0`.
            if (ball.transform.position.x < 0)
            {
                scoreP1.text = (++goalPlayerOne).ToString("f0");
                playerOne.transform.position = new Vector3(-6.0f, 0f, -3f);
                playerTwo.transform.position = new Vector3(6.0f, 0f, -3f);
                ball.transform.position = new Vector3(0f, 0f, -3f);
            }

        }

        if (goalPlayerOne >= victoryPoints)
        {
            SceneManager.LoadScene("MainMenu");
        }

    }
}
