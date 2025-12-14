using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;
    private Animator animator;
    private Vector2 moveInput;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Entrada de teclado
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");

        // Parámetros del Animator
        animator.SetFloat("xDirection", moveInput.x);
        animator.SetFloat("yDirection", moveInput.y);
        animator.SetFloat("Speed", moveInput.sqrMagnitude);
    }

    void FixedUpdate()
    {
        rb.linearVelocity = moveInput * speed;
    }
}
