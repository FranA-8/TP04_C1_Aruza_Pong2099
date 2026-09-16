using UnityEditor.Search;
using UnityEngine;

public class PlayerTwoMovement : MonoBehaviour
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
        if (Input.GetKeyDown(KeyCode.N))
        {
            transform.Rotate(Vector3.forward * rotateSpeed);
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            transform.Rotate(Vector3.forward * -rotateSpeed);
        }
        if (Input.GetKeyUp(KeyCode.B))
        {
            sr.color = new Color(Random.value, Random.value, Random.value);
        }
    }
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(new Vector2(0, moveSpeed * Time.fixedDeltaTime));
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(new Vector2(0, -moveSpeed * Time.fixedDeltaTime));
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(new Vector2(-moveSpeed * Time.fixedDeltaTime, 0));
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(new Vector2(moveSpeed * Time.fixedDeltaTime, 0));
        }
       
        rb.linearVelocity = Vector2.ClampMagnitude(rb.linearVelocity, maxSpeed);
    }
}