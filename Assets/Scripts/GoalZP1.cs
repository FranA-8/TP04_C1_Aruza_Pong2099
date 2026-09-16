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
    private int goalPlayerOne = 0;
    private int goalPlayerTwo = 0;
    private float victoryPoints = 3;
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
