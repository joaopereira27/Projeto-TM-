using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float distance = 10f;
    public float height = 5f;
    public float rotationSpeed = 100f;
    public float verticalSpeed = 3f;
    public float minHeight = 2f;
    public float maxHeight = 12f;

    private float currentAngle = 0f;

    void LateUpdate()
    {
        if (target == null) return;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            currentAngle -= rotationSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            currentAngle += rotationSpeed * Time.deltaTime;
        }

     

        height = Mathf.Clamp(height, minHeight, maxHeight);

        Quaternion rotation = Quaternion.Euler(0f, currentAngle, 0f);
        Vector3 offset = rotation * new Vector3(0f, 0f, -distance);

        transform.position = target.position + offset + Vector3.up * height;
        transform.LookAt(target.position);
    }
}