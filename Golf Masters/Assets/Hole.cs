using UnityEngine;

public class Hole : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (gameManager != null)
            {
                gameManager.Victory();
            }
        }
    }
}