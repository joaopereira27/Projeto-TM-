using UnityEngine;

public class GlobalGameManager : MonoBehaviour
{
    public static GlobalGameManager Instance;

    public int totalShots = 0;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddShot()
    {
        totalShots++;
        Debug.Log("AddShot -> " + totalShots);
    }

    public void ResetShots()
    {
        totalShots = 0;
        Debug.Log("ResetShots -> " + totalShots);
    }
}