using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest : MonoBehaviour
{
    [Header("AudioPlayer")]
    public ObjectAudioPlayer objectAudioPlayer;

    [Header("Collectables")]
    public GameObject Kartoffel;
    public GameObject Ei;
    public GameObject Karotte;

    [Header("Topf")]
    public GameObject Prop;

    [Header("Leitsystem")]
    public LineRenderer Line1;
    public LineRenderer Line2;
    public LineRenderer Line3;
    public LineRenderer Line4;

    Rigidbody rbKartoffel;
    Rigidbody rbEi;
    Rigidbody rbKarotte;

    Transform parentTransform;
    MeshCollider eimerCollider;
    AudioSource audioSource;

    bool bEi = false;
    bool bKartoffel = false;
    bool bKarotte = false;

    bool questStep1Complete = false;
    bool questStep2Complete = false;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        parentTransform = GetComponent<Transform>();
        eimerCollider = GetComponent<MeshCollider>();

        rbKartoffel = Kartoffel.GetComponent<Rigidbody>();
        rbEi = Ei.GetComponent<Rigidbody>();
        rbKarotte = Karotte.GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (bEi == true && bKartoffel == true && questStep1Complete == false)
        {
            QuestStep1();
            questStep1Complete = true;
        }

        if (bKarotte == true & questStep2Complete == false)
        {
            QuestStep2();
            questStep2Complete = true;
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

        if (collision.transform.gameObject == Karotte)
        {
            bKarotte = true;
            Karotte.transform.SetParent(parentTransform);
            rbKarotte.isKinematic = true;
        }
    }

    void QuestStep1()
    {
        objectAudioPlayer.PlayQuestStep1();
        Line1.enabled = false;
        Line2.enabled = false;
        Line3.enabled = true;
    }

    void QuestStep2()
    {
        objectAudioPlayer.PlayQuestStep2();
        Line3.enabled = false;
        Line4.enabled = true;
        Prop.SetActive(true);
    }

    public void KitchenSocket()
    {
        eimerCollider.enabled = false;

        Ei.transform.SetParent(null);
        Kartoffel.transform.SetParent(null);

        rbEi.isKinematic = false;
        rbKartoffel.isKinematic = false;
        rbKarotte.isKinematic = false;
    }
}
