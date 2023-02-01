using UnityEngine;

public class SoundController : MonoBehaviour
{
    public AudioClip soundEffect; //odwołanie do dźwięku
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>(); //pobieranie komponentu AudioSource
    }

    public void PlaySound()
    {
        audioSource.clip = soundEffect; //ustawienie dźwięku
        audioSource.Play(); //odtwarzanie dźwięku
    }
}