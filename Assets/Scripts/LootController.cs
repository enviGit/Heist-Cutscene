using UnityEngine;

public class LootController : MonoBehaviour
{
    public GameObject goldBarDepositBox;
    public GameObject goldBarHand;
    public GameObject goldBarBag;
    private float timer;

    void Start()
    {
        goldBarHand.SetActive(false);
        goldBarBag.SetActive(false);
    }
    void Update()
    {
        timer += Time.deltaTime;

        if(timer > 37.81f)
        {
            goldBarDepositBox.SetActive(false);
            goldBarHand.SetActive(true);
        }
        if (timer > 40.06f)
        {
            goldBarHand.SetActive(false);
            goldBarBag.SetActive(true);
        }
    }
}
