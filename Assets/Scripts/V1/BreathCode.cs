using UnityEngine;

public class BreathCode : MonoBehaviour
{
    [SerializeField] float pushStrength = 10f;

    private void OnTriggerStay2D(Collider2D other)
    {
        Rigidbody2D rb = other.GetComponent<Rigidbody2D>();

        if (rb != null )
        {
            rb.AddForce(transform.parent.up * pushStrength, ForceMode2D.Force);
            
        }
    }
}
