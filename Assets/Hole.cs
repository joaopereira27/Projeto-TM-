using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Hole : MonoBehaviour
{
    public float delayBeforeLoad = 1f;
    private AudioSource audioSource;
    private bool hasTriggered = false;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (hasTriggered) return;

        if (other.CompareTag("Player"))
        {
            hasTriggered = true;

            Rigidbody rb = other.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.linearVelocity = Vector3.zero;
                rb.angularVelocity = Vector3.zero;
                rb.isKinematic = true;
            }

            other.transform.position = transform.position + new Vector3(0f, 0.1f, 0f);

            StartCoroutine(PlaySoundAndLoadNextScene());
        }
    }

    IEnumerator PlaySoundAndLoadNextScene()
    {
        if (audioSource != null)
        {
            audioSource.Play();
        }

        yield return new WaitForSeconds(delayBeforeLoad);

        int currentIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentIndex + 1);
    }
}