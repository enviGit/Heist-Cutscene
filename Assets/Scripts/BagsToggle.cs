using UnityEngine;

public class BagsToggle : MonoBehaviour 
{
    private GameObject bag;
    public GameObject beforeLooting;
    private GameObject bagAfter;
    public GameObject lootingInProgress;
    public float waitTimeSeconds = 3f;
    public int waitTimeMilliseconds;
    private float waitTime;
    private float timer;

    void Start()
    {
	waitTime = waitTimeSeconds + waitTimeMilliseconds / 1000f;
        bag = transform.Find("Item_Duffel_Bag").gameObject;
        bagAfter = transform.Find("___TEMP - ItemDuffelBagAfter").gameObject;
    }
    void Update()
    {
        if(beforeLooting.activeInHierarchy == false)
            bag.SetActive(false);
        if(lootingInProgress.activeInHierarchy == true)
        {
            timer += Time.deltaTime;

            if (timer > waitTime)
                bagAfter.SetActive(true);
        }
    }
}