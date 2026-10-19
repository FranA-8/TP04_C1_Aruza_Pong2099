using Unity.VisualScripting;
using UnityEngine;

// Suggestion: a la clase le sobra una 'e', GameTimeer por GameTimer, y el error ya está en el nombre del archivo y en el inspector. Además el Update está declarado antes que el Start.
// Renombrala desde el Project de Unity y ordená los métodos por ciclo de vida: Awake, Start, Update.
// Warning: esta clase resta Time.deltaTime a un campo privado que nadie lee. El cronómetro real está duplicado adentro de GoalZP1 y GoalZP2, y encima este componente está puesto dos veces en la escena (en GoalZone1 y en GoalZone2).
// Este debería ser el único cronómetro del juego: que lea gameOptions.timer, avise cuando llega a cero y se reinicie. Ahí GoalZP1 y GoalZP2 dejan de tener su propia copia.
public class GameTimeer : MonoBehaviour
{
    private float timer = 20f;
    [SerializeField] private GameOptions gameOptions;

    private void Update()
    {
        timer -= Time.deltaTime;

    }
    private void Start()
    {
        timer = gameOptions.timer;
    }
}
