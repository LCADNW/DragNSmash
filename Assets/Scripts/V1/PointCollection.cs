using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PointCollection : MonoBehaviour
{
    [SerializeField] int point = 0;
    [SerializeField] int timer = 60;
    public TMP_Text scoreText;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            point++;
            Destroy(gameObject, 4);
            print(point);
            UpdateScoreUI();
        }
       
    }

    private void Start()
    {
        UpdateScoreUI();
    }

    private void UpdateScoreUI()
    {
        scoreText.text = "Score: " + point;
    }

}
