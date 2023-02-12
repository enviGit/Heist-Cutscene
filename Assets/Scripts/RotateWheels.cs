/*using Cinemachine;
using UnityEngine;

public class RotateWheels : MonoBehaviour
{
    public GameObject[] frontWheels;
    public GameObject[] backWheels;
    public float maxAngle = 30.0f;
    public float rotationXSpeed = 800f;
    public float rotationYSpeed = 25f;
    private float wheelRotationX;
    private float wheelRotationY;
    public CinemachineDollyCart dollyCart;

    void Update()
    {
        wheelRotationX += rotationXSpeed * Time.deltaTime;
        wheelRotationX = wheelRotationX % 360f;

        for (int i = 0; i < frontWheels.Length; i++)
        {
            if(i < 2)
            {
                wheelRotationY = Mathf.Clamp(dollyCart.m_Position * maxAngle * rotationYSpeed, -maxAngle, maxAngle);
                frontWheels[i].transform.localRotation = Quaternion.Euler(wheelRotationX, wheelRotationY, 0);
            }
            else
                frontWheels[i].transform.localRotation = Quaternion.Euler(wheelRotationX, 0, 0);
        }
        for (int i = 0; i < backWheels.Length; i++)
            backWheels[i].transform.localRotation = Quaternion.Euler(wheelRotationX, 0, 0);
    }
}*/
using Cinemachine;
using UnityEngine;

public class RotateWheels : MonoBehaviour
{
    public GameObject[] frontWheels;
    public GameObject[] backWheels;
    public float maxAngle = 30.0f;
    public float rotationXSpeed = 800f;
    public float rotationYSpeed = 25f;
    private float wheelRotationX;
    private float wheelRotationY;
    public CinemachineDollyCart dollyCart;
    private float timer;

    void Update()
    {
        timer += Time.deltaTime;
        wheelRotationX += rotationXSpeed * Time.deltaTime;
        wheelRotationX = wheelRotationX % 360f;

        for (int i = 0; i < frontWheels.Length; i++)
        {
            if (timer < 2f || timer > 58f)
            {
                if (i < 2)
                {
                    wheelRotationY = Mathf.Clamp(dollyCart.m_Position * maxAngle * rotationYSpeed, -maxAngle, maxAngle);
                    frontWheels[i].transform.localRotation = Quaternion.Euler(wheelRotationX, wheelRotationY, 0);
                }
                else
                    frontWheels[i].transform.localRotation = Quaternion.Euler(wheelRotationX, 0, 0);
            }
            else
                frontWheels[i].transform.localRotation = Quaternion.identity;
        }
        for (int i = 0; i < backWheels.Length; i++)
        {
            if (timer < 2f || timer > 58f)
                backWheels[i].transform.localRotation = Quaternion.Euler(wheelRotationX, 0, 0);
            else
                backWheels[i].transform.localRotation = Quaternion.identity;
        }
    }
}