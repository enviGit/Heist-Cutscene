using UnityEngine;

public class WeaponToggle : MonoBehaviour
{
    public GameObject weapon;
    public float waitTimeSeconds;
    public int waitTimeMilliseconds;
    private float waitTime;
    private float timer;

    void Start()
    {
        waitTime = waitTimeSeconds + waitTimeMilliseconds / 1000f;
    }
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > waitTime)
            weapon.SetActive(true);
    }
}
