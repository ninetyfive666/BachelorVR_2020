using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectAudioPlayer : MonoBehaviour
{   
    [Tooltip("Bilder")]
    public AudioClip Opa;
    public AudioClip Testament;
    public AudioClip Holz;
    public AudioClip Dreher;
    public AudioClip Handball;
    public AudioClip Naabquelle;
    public AudioClip Wiesenfest;

    [Tooltip("Objekte")]
    public AudioClip Sofa;

    AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public void PlayOpa()
    {
        audioSource.clip = (Opa);
        audioSource.Play();
    }

    public void PlayTestament()
    {
        audioSource.clip = (Testament);
        audioSource.Play();
    }

    public void PlayHolz()
    {
        audioSource.clip = (Holz);
        audioSource.Play();
    }

    public void PlayDreher()
    {
        audioSource.clip = (Dreher);
        audioSource.Play();
    }

    public void PlayHandball()
    {
        audioSource.clip = (Handball);
        audioSource.Play();
    }

    public void PlayNaabquelle()
    {
        audioSource.clip = (Naabquelle);
        audioSource.Play();
    }

    public void PlayWiesenfest()
    {
        audioSource.clip = (Wiesenfest);
        audioSource.Play();
    }

    public void PlaySofa()
    {
        audioSource.clip = (Sofa);
        audioSource.Play();
    }
}
