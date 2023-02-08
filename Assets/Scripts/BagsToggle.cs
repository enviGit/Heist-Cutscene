using UnityEngine;

public class BagsToggle : MonoBehaviour
{
    private GameObject bag;
    public GameObject beforeLooting;
    private GameObject bagAfter;
    public GameObject lootingInProgress;
    public GameObject rifle;
    public GameObject rifleAfter;
    public float waitTimeSeconds;
    public int waitTimeMilliseconds;
    private float waitTime;
    private float timer;

    void Start()
    {
        waitTime = waitTimeSeconds + waitTimeMilliseconds / 1000f;
        bag = transform.Find("Item_Duffel_Bag").gameObject;
        bagAfter = transform.Find("___TEMP - ItemDuffelBagAfter").gameObject;
        rifle.SetActive(true);
    }
    void Update()
    {
        if (beforeLooting.activeInHierarchy == false)
        {
            bag.SetActive(false);
            rifle.SetActive(false);
        }
        if (lootingInProgress.activeInHierarchy == true)
        {
            timer += Time.deltaTime;

            if (timer > waitTime)
            {
                bagAfter.SetActive(true);
                rifleAfter.SetActive(true);
            }
        }
    }
}