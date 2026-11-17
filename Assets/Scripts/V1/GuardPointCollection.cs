using UnityEngine;
using UnityEngine.Audio;

public class GuardPointCollection : MonoBehaviour
{
    private bool collected = false;
   
    [SerializeField] private AudioSource sound;

   
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !collected)
        {
            collected = true;

            sound.Play();
        

            ScoreManager.Instance.AddPoints(3);

            Destroy(gameObject, 3);
        }
    }
}