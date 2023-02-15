using UnityEngine;

public class SkyboxChanger : MonoBehaviour
{
    public Material skyboxMaterial;
    public float timeToChange;
    private float timer;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= timeToChange)
            RenderSettings.skybox = skyboxMaterial;
    }
}
