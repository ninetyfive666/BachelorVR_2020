using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayOnce : MonoBehaviour
{
    public AudioSource audioData;
    bool playedOnce = false;
    public void Start()
    {

        audioData = GetComponent<AudioSource>();

    }

    public void PlayOnce()
    {
        if (playedOnce == false)
        {
            audioData.Play(0);
            playedOnce = true;
            Debug.Log("Started Playback + Bool set to True");
        };
    }


}
