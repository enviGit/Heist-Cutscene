using UnityEngine;

public class SkyboxChanger : MonoBehaviour
{
    public Material skyboxMaterial;
    public float timeToChange = 49.05f;
    private float timer;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= timeToChange)
            RenderSettings.skybox = skyboxMaterial;
    }
}
