using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Singleton instance
    public static GameManager Instance { get; private set; }

    [Header("Game Stats")]
    public int score = 0;
    public int lives = 3;
    public int enemiesKilled = 0;

    [Header("UI References")]
    //public Text scoreText;
    public TMP_Text livesText;
    public TMP_Text enemiesKilledText;
    public GameObject gameOverPanel;
    public TMP_Text scoreText;

    public void StartMenu()
    {
        SceneManager.LoadScene("PlayableLevel");
    }

    private void Awake()
    {
        // Singleton pattern implementation
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Persist across scenes
        }
        else
        {
            Destroy(gameObject); // Destroy duplicate GameManagers
        }
    }

    private void Start()
    {
        UpdateUI();
    }

    public void AddScore(int points)
    {
        score += points;
        Debug.Log($"Score increased by {points}. Total: {score}");
        UpdateUI();
    }

    public void LoseLife()
    {
        lives--;
        Debug.Log($"Life lost! Lives remaining: {lives}");
        UpdateUI();

        if (lives <= 0)
        {
            GameOver();
        }
    }

    public void EnemyKilled()
    {
        enemiesKilled++;
        AddScore(100); // 100 points per enemy
        Debug.Log($"Enemy killed! Total enemies defeated: {enemiesKilled}");
    }

    public void quitGame()
    {
        Application.Quit();
    }

    public void replayLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        print("Let's Go Again!");
    }

    public void CollectiblePickedUp(int value)
    {
        AddScore(value);
        Debug.Log($"Collectible picked up worth {value} points!");
    }

    private void UpdateUI()
    {
        if (scoreText) scoreText.text = "Score: " + score;
        if (livesText) livesText.text = "Lives: " + lives;
        if (enemiesKilledText) enemiesKilledText.text = "Enemies: " + enemiesKilled;
    }

    private void GameOver()
    {
        Debug.Log("GAME OVER!");
        if (gameOverPanel) gameOverPanel.SetActive(true);
        Time.timeScale = 0f; // Pause the game
    }

    public void RestartGame()
    {
        /* score = 0;
        lives = 3;
        enemiesKilled = 0;
        Time.timeScale = 1f;
        if (gameOverPanel) gameOverPanel.SetActive(false);
        UpdateUI();*/


        // CRITICAL: Unpause the game first!
        Time.timeScale = 1f;

        // Reset all game state
        score = 0;
        lives = 3;
        enemiesKilled = 0;

        // Hide game over panel
        if (gameOverPanel) gameOverPanel.SetActive(false);

        // Destroy all enemies, bullets, and collectibles before reloading
        DestroyAllGameObjects();

        // Reload the current scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    private void DestroyAllGameObjects()
    {
        // Destroy all enemies
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject enemy in enemies)
        {
            Destroy(enemy);
        }

        // Destroy all bullets
        GameObject[] bullets = GameObject.FindGameObjectsWithTag("Bullet");
        foreach (GameObject bullet in bullets)
        {
            Destroy(bullet);
        }

        // Destroy all collectibles
        GameObject[] collectibles = GameObject.FindGameObjectsWithTag("Collectible");
        foreach (GameObject collectible in collectibles)
        {
            Destroy(collectible);
        }
    }
}
