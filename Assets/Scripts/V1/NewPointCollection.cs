using UnityEngine;
using UnityEngine.Audio;

public class NewPointCollection : MonoBehaviour
{
    private bool collected = false;
    public AudioSource sound;

    private void Start()
    {
        sound = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !collected)
        {
            collected = true;
            sound.PlayOneShot(sound.clip);
            ScoreManager.Instance.AddPoints(1);

            Destroy(gameObject, 3);
        }
    }
}