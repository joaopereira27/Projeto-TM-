using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        Debug.Log("Botão Jogar clicado");
        SceneManager.LoadScene("GolfArena");
    }
}