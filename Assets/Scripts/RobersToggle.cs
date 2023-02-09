using UnityEngine;
public class RobersToggle : MonoBehaviour
{
    public GameObject clown;
    public GameObject panda;
    public GameObject paperBag;
    public GameObject driver;
    public GameObject tempClown;
    public GameObject tempPanda;
    public GameObject bag;
    public GameObject bagAfter;
    public float waitTimeSeconds;
    public int waitTimeMilliseconds;
    private float waitTime;

    void Start()
    {
        panda.SetActive(false);
        clown.SetActive(false);
        paperBag.SetActive(false);
        driver.SetActive(true);
        tempPanda.SetActive(true);
        tempClown.SetActive(true);
        waitTime = waitTimeSeconds + waitTimeMilliseconds / 1000f;
        Invoke("TurnOff", waitTime - 0.1f);
        Invoke("TurnOn", waitTime);
        Invoke("Swap", 57.75f);
    }
    void TurnOff()
    {
        driver.SetActive(false);
        tempClown.SetActive(false);
        tempPanda.SetActive(false);
        bag.SetActive(false);
    }
    void TurnOn()
    {
        clown.SetActive(true);
        panda.SetActive(true);
        paperBag.SetActive(true);
    }
    void Swap()
    {
        clown.SetActive(false);
        panda.SetActive(false);
        paperBag.SetActive(false);
        driver.SetActive(true);
        tempClown.SetActive(true);
        tempPanda.SetActive(true);
        bagAfter.SetActive(true);
    }
}
