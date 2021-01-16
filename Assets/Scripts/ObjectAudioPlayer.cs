using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectAudioPlayer : MonoBehaviour
{   
    [Header("Bilder")]
    public AudioClip Opa;
    public AudioClip Testament;
    public AudioClip Holz;
    public AudioClip Dreher;
    public AudioClip Handball;
    public AudioClip Naabquelle;
    public AudioClip Wiesenfest;

    [Header("Objekte")]
    public AudioClip Sofa;
    public AudioClip Pumpe;

    [Header("PlayOnlyOnce")]
    public AudioClip Kartoffel;
    public AudioClip Ei;
    public AudioClip Karotte;
    public AudioClip Feuerholz;

    [Header("KochQuest")]
    public AudioClip questStart;
    public AudioClip questStep1;
    public AudioClip questStep2;
    public AudioClip questStep3;

    [Header("WaschQuest")]
    public AudioClip washingQuestStart;
    public AudioClip washingQuestStep1;
    public AudioClip washingQuestStep2;
    public AudioClip washingQuestStep3;

    AudioSource audioSource;

    bool bEi = false;
    bool bKartoffel = false;
    bool bFeuerholz = false;
    bool bKarotte = false;

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

    public void PlayPumpe()
    {
        audioSource.clip = (Pumpe);
        audioSource.Play();
    }
    public void PlayFeuerholz()
    {
        if (bFeuerholz == false)
        {
            audioSource.clip = (Feuerholz);
            audioSource.Play();
            bFeuerholz = true;
        }
    }
    public void PlayKartoffel()
    {   
        if (bKartoffel == false)
        {
            audioSource.clip = (Feuerholz);
            audioSource.Play();
            bKartoffel = true; 
        }

    }
    public void PlayEi()
    {
        if (bEi == false)
        {
            audioSource.clip = (Feuerholz);
            audioSource.Play();
            bEi = true;
        }

    }

    public void PlayKarotte()
    {
        if (bKarotte == false)
        {
            audioSource.clip = (Karotte);
            audioSource.Play();
            bKarotte = true;
        }

    }

    public void PlayQuestStep1()
    {
        audioSource.clip = (questStep1);
        audioSource.Play();
    }

    public void PlayQuestStep2()
    {
        audioSource.clip = (questStep2);
        audioSource.Play();
    }

    public void PlayQuestStep3()
    {
        audioSource.clip = (questStep3);
        audioSource.Play();
    }

    public void PlayQuestStart()
    {
        audioSource.clip = (questStart);
        audioSource.Play();
    }

    public void PlayWhashingQuestStart()
    {
        audioSource.clip = (washingQuestStart);
        audioSource.Play();
    }

    public void PlayWhashingQuestStep1()
    {
        audioSource.clip = (washingQuestStep1);
        audioSource.Play();
    }
    public void PlayWhashingQuestStep2()
    {
        audioSource.clip = (washingQuestStep2);
        audioSource.Play();
    }

    public void PlayWhashingQuestStep3()
    {
        audioSource.clip = (washingQuestStep3);
        audioSource.Play();
    }
}
