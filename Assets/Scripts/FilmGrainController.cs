using System;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class FilmGrainController : MonoBehaviour
{
    private PostProcessVolume volume;
    private PostProcessProfile profile;

    private void OnEnable()
    {
        volume = GetComponent<PostProcessVolume>();
        profile = volume.profile;
    }

    private void Update()
    {
        if (Camera.current == GetComponent<Camera>())
        {
            Grain grain;

            if (profile.TryGetSettings(out grain))
                grain.intensity.value = 0.5f;
        }
        else
        {
            Grain grain;

            if (profile.TryGetSettings(out grain))
                grain.intensity.value = 0f;
        }
    }
}