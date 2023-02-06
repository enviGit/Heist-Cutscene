using UnityEngine;

public class SafeLootingToggle : MonoBehaviour
{
    public GameObject beforeLooting;
    public GameObject lootingInProgress;
    public float lootingWaitTimeSeconds = 3f;
    public int lootingWaitTimeMilliseconds;
    private float lootingTotalWaitTime;
    private float timer;

    void Start()
    {
        lootingTotalWaitTime = lootingWaitTimeSeconds + lootingWaitTimeMilliseconds / 1000f;
    }
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > lootingTotalWaitTime)
        {
            beforeLooting.SetActive(false);
            lootingInProgress.SetActive(true);
        }
    }
}