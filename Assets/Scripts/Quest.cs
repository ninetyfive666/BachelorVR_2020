using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest : MonoBehaviour
{

    public GameObject Kartoffel;
    public GameObject Ei;
    public GameObject Prop;

    Rigidbody rbKartoffel;
    Rigidbody rbEi;

    Transform parentTransform;
    MeshCollider eimerCollider;
    AudioSource audioSource;

    bool bEi = false;
    bool bKartoffel = false;
    bool bAudio = false;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        parentTransform = GetComponent<Transform>();
        eimerCollider = GetComponent<MeshCollider>();

        rbKartoffel = Kartoffel.GetComponent<Rigidbody>();
        rbEi = Ei.GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (bEi == true && bKartoffel == true && bAudio == false)
        {
            AudioPlayer();
            bAudio = true;
        }

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.gameObject == Kartoffel)
        {
            bKartoffel = true;
            Kartoffel.transform.SetParent(parentTransform);
            rbKartoffel.isKinematic = true;

        }

        if (collision.transform.gameObject == Ei)
        {
            bEi = true;
            Ei.transform.SetParent(parentTransform);
            rbEi.isKinematic = true;
        }
    }

    void AudioPlayer()
    {
        audioSource.Play();
        Prop.SetActive(true);
    }

    public void KitchenSocket()
    {
        eimerCollider.enabled = false;

        Ei.transform.SetParent(null);
        Kartoffel.transform.SetParent(null);

        rbEi.isKinematic = false;
        rbKartoffel.isKinematic = false;
        
        
    }
}
