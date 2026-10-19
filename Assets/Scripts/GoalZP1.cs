using System.Runtime.CompilerServices;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalZP1 : MonoBehaviour
{
    [SerializeField] private GameOptions gameOptions;
    [SerializeField] private TMP_Text scoreP1;
    [SerializeField] private TMP_Text scoreP2;

    [SerializeField] private GameObject playerOne;
    [SerializeField] private GameObject playerTwo;
    [SerializeField] private GameObject ball;
    // Suggestion: goalPlayerOne se declara y nunca se usa en esta clase (acá solo se cuenta goalPlayerTwo). En GoalZP2.cs:18 pasa lo mismo al revés.
    // Borralo, o mejor: llevá el marcador a un solo script de partida y que las dos zonas de gol le avisen.
    private int goalPlayerOne = 0;
    private int goalPlayerTwo = 0;
    private float victoryPoints = 3;
    // Bug: este timer arranca en 20 hardcodeado (no lee gameOptions.timer, que es lo que pide la consigna) y nunca se reinicia.
    // A los 20 segundos `timer <= 0` queda en true para siempre, así que el bloque del Update se ejecuta en CADA frame mientras la pelota esté del lado izquierdo: el marcador sube de a uno por frame y la partida termina sola.
    // Inicializalo en el Start con gameOptions.timer y volvé a ponerlo en ese valor cada vez que se convierte un gol.
    private float timer = 20f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            scoreP2.text = (++goalPlayerTwo).ToString("f0");
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
            if (ball.transform.position.x <0)
            {
                scoreP2.text = (++goalPlayerTwo).ToString("f0");
                playerOne.transform.position = new Vector3(-6.0f, 0f, -3f);
                playerTwo.transform.position = new Vector3(6.0f, 0f, -3f);
                ball.transform.position = new Vector3(0f, 0f, -3f);
            }

        }

        if (goalPlayerTwo >= victoryPoints)
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
