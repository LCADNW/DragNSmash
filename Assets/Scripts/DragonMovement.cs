using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class DragonMovement : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] float moveSpeed = 10f;
    [SerializeField] float flySpeed = 20f;
    public bool isFlying;
    public bool isGrounded;

    private Rigidbody2D rb;
    private Vector2 moveInput;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isGrounded = true;
    }

    void FixedUpdate()
    {
        rb.linearVelocity = moveInput * moveSpeed;
    }

    public void Move(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }

    public void Flight()
    {
        if (isFlying) { }
    }

    public void Grounded()
    {
        if (isGrounded)
        {

        }
    }
}



