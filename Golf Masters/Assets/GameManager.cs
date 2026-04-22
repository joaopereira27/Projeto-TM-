using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI shotsText;

    void Start()
    {
        UpdateShotsUI();
    }

    public void AddShot()
    {
        UpdateShotsUI();
    }

    public void UpdateShotsUI()
    {
        if (shotsText != null && GlobalGameManager.Instance != null)
        {
            shotsText.text = "Tacadas: " + GlobalGameManager.Instance.totalShots;
        }
    }
}