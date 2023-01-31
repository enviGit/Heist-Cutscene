using UnityEngine;

public class DoorToggle : MonoBehaviour 
{
    public GameObject doorClosed;
    public GameObject beforeLooting;
    public GameObject doorOpened;
    public GameObject lootingInProgress;
    public float waitTimeSeconds = 3f;
    public int waitTimeMilliseconds;
    private float waitTime;
    private float timer;

    void Start()
    {
	waitTime = waitTimeSeconds + waitTimeMilliseconds / 1000f;
    }
    void Update()
    {
        //if(beforeLooting.activeInHierarchy == false)
           
        timer += Time.deltaTime;

        if (timer > waitTime)
	{
            doorClosed.SetActive(false);
            doorOpened.SetActive(true);
        }

	if (timer > waitTime + 3f)
	{
            beforeLooting.SetActive(false);
            lootingInProgress.SetActive(true);
        }
    }
}