using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        if (GlobalGameManager.Instance != null)
        {
            GlobalGameManager.Instance.ResetShots();
        }

        SceneManager.LoadScene("GolfArena");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}