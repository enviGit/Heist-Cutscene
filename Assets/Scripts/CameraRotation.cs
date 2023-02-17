using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    public float rotationSpeed = 1f;
    private bool rotateLeft = true;

    private void Update()
    {
        if (rotateLeft)
        {
            transform.Rotate(Vector3.up, -rotationSpeed * Time.deltaTime);

            if (transform.eulerAngles.y <= 297.29f)
                rotateLeft = false;
        }
        else
        {
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);

            if (transform.eulerAngles.y >= 303.29f)
                rotateLeft = true;
        }
    }
}