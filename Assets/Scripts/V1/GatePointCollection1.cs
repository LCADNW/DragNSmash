using UnityEngine;
using UnityEngine.Audio;

public class GatePointCollection : MonoBehaviour
{
    private bool collected = false;
   
    [SerializeField] private AudioSource sound;
    [SerializeField] private AudioSource sound2;

   
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !collected)
        {
            collected = true;

            sound.Play();
            sound2.Play();

            ScoreManager.Instance.AddPoints(2);

            Destroy(gameObject, 3);
        }
    }
}