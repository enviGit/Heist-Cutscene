using UnityEngine;
public class RobersToggle : MonoBehaviour
{
    public GameObject clown;
    public GameObject panda;
    public GameObject paperBag;
    public float waitTimeSeconds;
    public int waitTimeMilliseconds;
    private float waitTime;

    void Start()
    {
	    waitTime = waitTimeSeconds + waitTimeMilliseconds / 1000f;
        Invoke("TurnOn", waitTime);
    }
    void TurnOn()
    {
	    clown.SetActive(true);
	    panda.SetActive(true);
	    paperBag.SetActive(true);
    }
}