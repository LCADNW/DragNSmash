using Unity.VisualScripting;
using UnityEditor.Rendering.LookDev;
using UnityEngine;
using UnityEngine.InputSystem;

public class DragonMovement : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] float moveSpeed = 10f;
    public bool isFlying = false;
    public bool isGrounded
    {
        get {  return !isFlying; }
    }

    private Rigidbody2D rb;
    private Vector2 moveInput;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        rb.linearVelocity = moveInput * moveSpeed;
        //debug log check
        if (isGrounded)
        {
            
        }

        if (isFlying)
        {
            
        }
    }

    void Update()
    {
        if (isFlying)
        {
            moveSpeed = 20f;
        }

       if (isGrounded)
        {
            moveSpeed = 10f;
        }
    }

    public void OnFly()
    {
        isFlying = !isFlying;
    }


    public void Move(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }

}



