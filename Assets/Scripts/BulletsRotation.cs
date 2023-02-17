using UnityEngine;

public class BulletsRotation : MonoBehaviour
{
    public float rotationSpeed = 500f;
    public Vector3 rotationAxis = Vector3.up;

    private void Update()
    {
        transform.Rotate(rotationAxis, rotationSpeed * Time.deltaTime);
    }
}