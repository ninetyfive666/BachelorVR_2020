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
    public AudioClip Badewanne;
    public AudioClip Huhn;

    [Header("PlayOnlyOnce")]
    public AudioClip Kartoffel;
    public AudioClip Petersilie;
    public AudioClip Karotte;
    public AudioClip Feuerholz;
    public AudioClip washingQuestStep1;

    [Header("KochQuest")]
    public AudioClip questStart;
    public AudioClip questStep1;
    public AudioClip questStep2;
    public AudioClip questStep3;

    [Header("WaschQuest")]
    public AudioClip washingQuestStart;
    public AudioClip washingQuestStep2;
    public AudioClip washingQuestStep3;
    AudioSource audioSource;

    bool bEi = false;
    bool bKartoffel = false;
    bool bFeuerholz = false;
    bool bKarotte = false;
    bool bKleidung = false;

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

    public void PlayBadewanne()
    {
        audioSource.clip = (Badewanne);
        audioSource.Play();
    }

    public void PlayHuhn()
    {
        audioSource.clip = (Huhn);
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
            audioSource.clip = (Kartoffel);
            audioSource.Play();
            bKartoffel = true; 
        }

    }
    public void PlayPetersilie()
    {
        if (bEi == false)
        {
            audioSource.clip = (Petersilie);
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
        if (bKleidung == false)
        {
            audioSource.clip = (washingQuestStep1);
            audioSource.Play();
            bKleidung = true;
        }

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
