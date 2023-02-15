using UnityEngine;

public class BladesRotation : MonoBehaviour
{
    public GameObject backBlade;
    public GameObject mainBlade;

    void Update()
    {
        backBlade.transform.Rotate(Vector3.right, 2304f * Time.deltaTime);
        mainBlade.transform.Rotate(Vector3.up, 1620f * Time.deltaTime);
    }
}
