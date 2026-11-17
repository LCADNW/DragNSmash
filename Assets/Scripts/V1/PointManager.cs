using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;

    public int points = 0;
    public TMP_Text scoreText;

    private void Awake()
    {
        Instance = this;
    }

    public void AddPoints(int amount)
    {
        points += amount;
        scoreText.text = "Score: " + points;
    }
}