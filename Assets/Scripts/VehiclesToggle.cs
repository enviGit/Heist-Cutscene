using System.Threading;
using UnityEngine;

public class VehiclesToggle : MonoBehaviour
{
    public GameObject [] vehicles;
    public float waitTime;
    private float timer;

    void Start()
    {
        foreach(var vehicle in vehicles)
            vehicle.SetActive(false);
    }
    void Update()
    {
        timer += Time.deltaTime;

        if(timer >= waitTime)
            foreach(var vehicle in vehicles)
                vehicle.SetActive(true);
    }
}
