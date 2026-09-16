using Unity.VisualScripting;
using UnityEngine;

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
