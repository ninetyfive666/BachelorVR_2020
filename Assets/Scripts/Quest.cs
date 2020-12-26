using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest : MonoBehaviour
{
    AudioSource audioSource;
    public GameObject Kartoffel;
    public GameObject Ei;

    public GameObject New;

    bool bEi = false;
    bool bKartoffel = false;
    bool bAudio = false;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (bEi == true && bKartoffel == true && bAudio == false)
        {
            AudioPlayer();
            bAudio = true;
            Debug.Log("boool isch trieeee");
        }

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.gameObject == Kartoffel)
        {
            bKartoffel = true;
            Debug.Log("Kartoffel im Eimer");
        }

        if (collision.transform.gameObject == Ei)
        {
            bEi = true;
            Debug.Log("Ei im Eimer");
            
        }
    }

    void AudioPlayer()
    {
        audioSource.Play();
        New.SetActive(true);
    }
}
