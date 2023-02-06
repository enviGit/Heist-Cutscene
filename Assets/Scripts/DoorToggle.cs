using UnityEngine;

public class DoorToggle : MonoBehaviour 
{
    public GameObject doorClosed;
    public GameObject beforeLooting;
    public GameObject doorOpened;
    public GameObject lootingInProgress;
    public float doorWaitTimeSeconds = 3f;
    public int doorWaitTimeMilliseconds;
    private float doorTotalWaitTime;
    public float lootingWaitTimeSeconds = 3f;
    public int lootingWaitTimeMilliseconds;
    private float lootingTotalWaitTime;
    private float timer;

    void Start()
    {
	doorTotalWaitTime = doorWaitTimeSeconds + doorWaitTimeMilliseconds / 1000f;
	lootingTotalWaitTime = lootingWaitTimeSeconds + lootingWaitTimeMilliseconds / 1000f;
    }
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > doorTotalWaitTime)
	{
            doorClosed.SetActive(false);
            doorOpened.SetActive(true);
        }

	if (timer > doorTotalWaitTime + lootingTotalWaitTime)
	{
            beforeLooting.SetActive(false);
            lootingInProgress.SetActive(true);
        }
    }
}