using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    public int score = 0;
    public TMP_Text scoreText; // your UI score text
    public int lives = 5;
    public TMP_Text livesText;
    public GameObject FishCatchSound;

    void Awake()
    {
        Instance = this;
        scoreText.text = "0";
        livesText.text = "Lives: 5";
    }

    public void AddScore(int amount)
    {
        score += amount;
        scoreText.text = System.Convert.ToString(score);
        if (FishCatchSound != null)
        {
            FishCatchSound.GetComponent<AudioSource>().Play();
        }
    }
    public void RemoveLives()
    {
        if (score > 1)
        {
            score -= 1;
        }
        lives -= 1;
        livesText.text = "Lives: " + System.Convert.ToString(lives);
        if (lives == 0)
        {
            GameManager.Instance.GameOver();
        }
    }


}