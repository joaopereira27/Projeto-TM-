using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class FinalMenu : MonoBehaviour
{
    public TextMeshProUGUI Score;

    void Start()
    {
        if (GlobalGameManager.Instance != null)
        {
            Debug.Log("Final totalShots = " + GlobalGameManager.Instance.totalShots);
        }
        else
        {
            Debug.Log("GlobalGameManager.Instance é NULL");
        }

        if (Score == null)
        {
            Debug.Log("Score está NULL no Inspector");
        }

        if (GlobalGameManager.Instance != null && Score != null)
        {
            Score.text = "Terminaste o jogo em " + GlobalGameManager.Instance.totalShots + " tacadas!";
        }
    }

    public void RestartGame()
    {
        if (GlobalGameManager.Instance != null)
        {
            GlobalGameManager.Instance.ResetShots();
        }

        SceneManager.LoadScene("GolfArena");
    }

    public void GoToMainMenu()
    {
        if (GlobalGameManager.Instance != null)
        {
            GlobalGameManager.Instance.ResetShots();
        }

        SceneManager.LoadScene("MainMenu");
    }
}