using UnityEngine;

public class BulletRotation : MonoBehaviour
{
    public float rotationSpeed;
    public Vector3 rotationAxis = Vector3.forward;

    private void Update()
    {
        transform.Rotate(rotationAxis, rotationSpeed * Time.deltaTime);
    }
}