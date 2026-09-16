using UnityEngine;
[CreateAssetMenu(fileName = "GameOptions", menuName = "Game/GameOptions")] 
public class GameOptions : ScriptableObject
{
    public float timer = 20f;
    public float victoryPoints = 3f;
    public float moveSpeed = 1000f;
    public float rotateSpeed = 15f;
    public Color color = Color.white;

}
