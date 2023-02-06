using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JewelleryToggle : MonoBehaviour
{
    public GameObject displayCaseToAnimate;
    public GameObject jewellery;
    public float secondsForAnimatedDisplayCase;
    public int millisecondsForAnimatedDisplayCase;
    private float waitTimeForAnimatedDisplayCase;
    public List<GameObject> restItems;
    public float secondsForRestItems;
    public int millisecondsForRestItems;
    private float waitTimeForRestItems;

    void Start()
    {
        waitTimeForAnimatedDisplayCase = secondsForAnimatedDisplayCase + millisecondsForAnimatedDisplayCase / 1000f;
        Invoke("DisplayCaseToAnimateToggle", waitTimeForAnimatedDisplayCase);
        waitTimeForRestItems = secondsForRestItems + millisecondsForRestItems / 1000f;
        Invoke("RestItemsToggle", waitTimeForRestItems);
    }
    void DisplayCaseToAnimateToggle()
    {
        displayCaseToAnimate.transform.Find("SM_Prop_DisplayCase_Glass_01").gameObject.SetActive(false);
        displayCaseToAnimate.transform.Find("SM_Prop_DisplayCase_Glass_1_Broken").gameObject.SetActive(true);
    }
    void RestItemsToggle()
    {
        foreach (GameObject item in restItems)
        {
            item.transform.Find("SM_Prop_DisplayCase_Glass_01").gameObject.SetActive(false);
            item.transform.Find("SM_Prop_DisplayCase_Glass_1_Broken").gameObject.SetActive(true);
        }

        jewellery.gameObject.SetActive(false);
    }
}
