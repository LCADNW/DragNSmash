using UnityEngine;
using UnityEngine.InputSystem;

public class DragonBreath : MonoBehaviour
{
    public Collider2D breathCollider;

    void Start()
    {
        breathCollider.enabled = false;
    }

    public void Breath(InputAction.CallbackContext context)
    {
        breathCollider.enabled = context.ReadValueAsButton();
    }

}
