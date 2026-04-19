using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public TextMeshProUGUI messageText;
    public TextMeshProUGUI shotsText;

    private int shots = 0;
    private bool gameEnded = false;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        UpdateShotsUI();

        if (messageText != null)
            messageText.text = "";
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            RestartGame();
        }
    }

    public void AddShot()
    {
        if (gameEnded) return;

        shots++;
        UpdateShotsUI();
    }

    public void Victory()
    {
        if (gameEnded) return;

        gameEnded = true;

        if (messageText != null)
            messageText.text = "Vitória! Carrega R para reiniciar";
    }

    public void GameOver()
    {
        if (gameEnded) return;

        gameEnded = true;

        if (messageText != null)
            messageText.text = "Game Over! Carrega R para reiniciar";
    }

    void UpdateShotsUI()
    {
        if (shotsText != null)
            shotsText.text = "Tacadas: " + shots;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}