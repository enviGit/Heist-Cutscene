using UnityEngine;
public class RobersToggle : MonoBehaviour
{
    public GameObject clown;
    public GameObject panda;
    public GameObject paperBag;
    public GameObject driver;
    public float waitTimeSeconds;
    public int waitTimeMilliseconds;
    private float waitTime;

    void Start()
    {
        clown.SetActive(false);
        panda.SetActive(false);
        paperBag.SetActive(false);
        waitTime = waitTimeSeconds + waitTimeMilliseconds / 1000f;
        Invoke("TurnOff", waitTime - 0.1f);
        Invoke("TurnOn", waitTime);
        Invoke("Swap", 57.75f);
    }
    void TurnOff()
    {
        driver.SetActive(false);
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
    }
}
