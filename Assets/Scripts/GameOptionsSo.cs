using UnityEngine;
[CreateAssetMenu(fileName = "GameOptions", menuName = "Game/GameOptions")] 
// Error: el archivo se llama GameOptionsSo.cs y la clase GameOptions. Vale lo mismo que en PlayerOneMovement.cs: el nombre del archivo tiene que ser igual al de la clase.
// Renombrá el archivo a GameOptions.cs desde el Project de Unity.
public class GameOptions : ScriptableObject
{
    // Warning: los cinco campos del ScriptableObject son public, así que cualquier script puede pisarlos y el cambio queda grabado en el .asset.
    // Dejalos [SerializeField] private con properties de solo lectura.
    // Bug: Assets/Data/GameOptionsP2.asset todavía tiene los campos de una versión vieja de esta clase (`gameplayTime`, `gameRounds`, `playerSpeed`, `heigth`), que ya no existen acá.
    // Al deserializar, esos valores se descartan y el jugador 2 arranca con los defaults de arriba en vez de con lo que dice el asset. Abrí el .asset en el inspector y volvé a cargarle los valores.
    public float timer = 20f;
    public float victoryPoints = 3f;
    public float moveSpeed = 1000f;
    public float rotateSpeed = 15f;
    public Color color = Color.white;

}
