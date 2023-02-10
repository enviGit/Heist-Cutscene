using UnityEngine;

public class MoveHelicopter : MonoBehaviour
{
    public Transform target1;
    public Transform target2;
    public float speed = 10f;
    public float rotationSpeed = 3f;
    public float rotationThreshold = 3f;
    public float liftOffHeight = 1f;
    private int currentTarget = 1;
    private Vector3 direction;
    private Quaternion targetRotation;
    private float waitTime = 0.2f;
    private float elapsedTime = 0f;

    void Start()
    {
        direction = (target1.position - transform.position).normalized;
        targetRotation = Quaternion.LookRotation(direction);
    }
    void Update()
    {
        if (currentTarget == 1)
        {
            if (Quaternion.Angle(transform.rotation, targetRotation) > rotationThreshold)
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
            else
            {
                elapsedTime += Time.deltaTime;

                if (elapsedTime >= waitTime) 
                {
                    Vector3 target1WithLiftOffHeight = new Vector3(target1.position.x, target1.position.y + liftOffHeight, target1.position.z);
                    transform.position = Vector3.MoveTowards(transform.position, target1WithLiftOffHeight, speed * Time.deltaTime);

                    if (Vector3.Distance(transform.position, target1WithLiftOffHeight) < 0.1f)
                    {
                        currentTarget = 2;
                        elapsedTime = 0f;
                        direction = (target2.position - transform.position).normalized;
                        targetRotation = Quaternion.LookRotation(direction);
                    }
                }
            }
        }
        else if (currentTarget == 2)
        {
            if (Quaternion.Angle(transform.rotation, targetRotation) > rotationThreshold)
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
            else
            {
                elapsedTime += Time.deltaTime;

                if (elapsedTime >= waitTime) 
                {
                    Vector3 target2WithLiftOffHeight = new Vector3(target2.position.x, target2.position.y + liftOffHeight, target2.position.z);
                    transform.position = Vector3.MoveTowards(transform.position, target2WithLiftOffHeight, speed * Time.deltaTime);
                }
            }
        }
    }
}
