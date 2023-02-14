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

        if(timer >= waitTime - 4f)
            vehicles[0].SetActive(true);
        if (timer >= waitTime)
            for (int i = 1; i <= vehicles.Length - 1; i++)
                vehicles[i].SetActive(true);
    }
}
