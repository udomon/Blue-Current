using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameObject gameOverScreen; // drag your Game Over UI panel here
    public GameObject EndSound;



    void Awake()
    {
        Instance = this;
        gameOverScreen.SetActive(false); // hide at start

    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true); // show game over screen
        Time.timeScale = 0f;           // pause the game

        if (EndSound != null)
        {
            EndSound.GetComponent<AudioSource>().Play();
        }
    }

    public void Restart()
    {
        Time.timeScale = 1f;           // unpause before reloading
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
