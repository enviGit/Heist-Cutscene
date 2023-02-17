using UnityEngine;

public class CameraFollowingTheBullet : MonoBehaviour
{
    public Transform bulletTransform;
    public float cameraSpeed = 35f;
    private Vector3 cameraOffset;

    private void Start()
    {
        cameraOffset = transform.position - bulletTransform.position;
    }
    private void FixedUpdate()
    {
        Vector3 targetPosition = bulletTransform.position + cameraOffset;
        transform.position = Vector3.Lerp(transform.position, targetPosition, cameraSpeed * Time.deltaTime);
    }
}