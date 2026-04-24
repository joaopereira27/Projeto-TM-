using TMPro;
using UnityEngine;
using UnityEngine.Audio;



public class GolfBall : MonoBehaviour
{
    private Rigidbody rb;

    public float[] forceLevels = { 8f, 13f, 20f };
    private int currentForceLevel = 1; // 0,1,2 => mostra 1,2,3
    public AudioClip shotSound;
    private AudioSource audioSource;

    public float minVelocity = 0.15f;
    private bool canShoot = true;

    public GameManager gameManager;
    public TextMeshProUGUI forceText;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
        UpdateForceUI();
        Debug.Log("GolfBall Start OK");
    }

    void Update()
    {
        if (rb == null) return;

        if (rb.linearVelocity.magnitude < minVelocity && !canShoot)
        {
            rb.linearVelocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
            canShoot = true;
        }

        if (canShoot && Input.GetKeyDown(KeyCode.UpArrow))
        {
            currentForceLevel++;
            currentForceLevel = Mathf.Clamp(currentForceLevel, 0, 2);
            UpdateForceUI();
        }

        if (canShoot && Input.GetKeyDown(KeyCode.DownArrow))
        {
            currentForceLevel--;
            currentForceLevel = Mathf.Clamp(currentForceLevel, 0, 2);
            UpdateForceUI();
        }

        if (Input.GetKeyDown(KeyCode.Space) && canShoot)
        {
            ShootForwardFromCamera();
        }
    }

    void ShootForwardFromCamera()
    {
        if (Camera.main == null)
        {
            Debug.LogError("Camera.main é NULL");
            return;
        }

        Vector3 camForward = Camera.main.transform.forward;
        camForward.y = 0f;
        camForward = camForward.normalized;

        if (camForward.magnitude > 0.1f)
        {
            float shotPower = forceLevels[currentForceLevel];

            if (audioSource != null && shotSound != null)
            {
                audioSource.PlayOneShot(shotSound, 0.5f);
            }

            rb.AddForce(camForward * shotPower, ForceMode.Impulse);
            canShoot = false;

            if (GlobalGameManager.Instance != null)
            {
                GlobalGameManager.Instance.AddShot();
            }

            if (gameManager != null)
            {
                gameManager.AddShot();
            }
        }
    }

    void UpdateForceUI()
    {
        if (forceText != null)
        {
            forceText.text = "Força: " + (currentForceLevel + 1) + "/3";
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
           //ADICIONAR SOM
        }
    }
}