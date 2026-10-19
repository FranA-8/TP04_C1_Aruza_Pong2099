using System.Xml.Linq;
using Unity.VisualScripting;
using UnityEngine;

// Error: el archivo se llama PlayerOneMovement.cs y la clase PlayerSpeed. Unity busca dentro de cada .cs una clase con el mismo nombre que el archivo; cuando no la encuentra, el componente no se puede agregar y los que ya estaban puestos aparecen como faltantes.
// Renombrá la clase a PlayerOneMovement (o el archivo a PlayerSpeed.cs) desde el Project de Unity, para que el .meta viaje con el archivo. Acordate de que UiSettingsMenu.cs:75 también pide GetComponent<PlayerSpeed>().
public class PlayerSpeed : MonoBehaviour
{
    [SerializeField] private GameOptions gameOptions;
    private float moveSpeed = 1000.0f;
    private float maxSpeed = 1200.0f;
    private float rotateSpeed = 15f;
    private Rigidbody2D rb;
    private SpriteRenderer sr;

    internal void SetMoveSpeed(float value)
    {
        moveSpeed = value;
    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }
    private void Start()
    {
        sr.color = gameOptions.color;
        moveSpeed = gameOptions.moveSpeed;
        rotateSpeed = gameOptions.rotateSpeed;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            transform.Rotate(Vector3.forward * rotateSpeed);
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            transform.Rotate(Vector3.forward * -rotateSpeed);
        }
        if (Input.GetKeyUp(KeyCode.R))
        {
            sr.color = new Color(Random.value, Random.value, Random.value);
        }
    }
    private void FixedUpdate()
    {
            if (Input.GetKey(KeyCode.W))
            {
                // Warning: AddForce ya integra el tiempo por dentro, no hay que multiplicar por Time.fixedDeltaTime. Como fixedDeltaTime vale 0.02, la fuerza queda dividida por cincuenta, y por eso terminás necesitando moveSpeed = 1000.
                // Sacá el Time.fixedDeltaTime y bajá moveSpeed. Lo mismo en las cuatro llamadas de PlayerTwoMovement.cs:49-61.
                rb.AddForce(new Vector2(0, moveSpeed * Time.fixedDeltaTime));
            }
            if (Input.GetKey(KeyCode.S))
            {
                rb.AddForce(new Vector2(0, -moveSpeed * Time.fixedDeltaTime));
            }
            if (Input.GetKey(KeyCode.A))
            {
                rb.AddForce(new Vector2(-moveSpeed * Time.fixedDeltaTime, 0));
            }
            if (Input.GetKey(KeyCode.D))
            {
                rb.AddForce(new Vector2(moveSpeed * Time.fixedDeltaTime, 0));
            }


            rb.linearVelocity = Vector2.ClampMagnitude(rb.linearVelocity, maxSpeed);
    }

}