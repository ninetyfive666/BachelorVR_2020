using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest : MonoBehaviour
{
    [Header("AudioPlayer")]
    public ObjectAudioPlayer objectAudioPlayer;

    [Header("External Collider")]
    public CollisionCheck collisionCheck;
    public GameObject QuestCollider;
    public GameObject EimerCollider;

    [Header("Collectables")]
    public GameObject Kartoffel;
    public GameObject Ei;
    public GameObject Karotte;

    [Header("Topf")]
    public GameObject Prop;
    public GameObject[] spawnArray;


    [Header("Leitsystem")]
    public LineRenderer Line1;
    public LineRenderer Line2;
    public LineRenderer Line3;
    public LineRenderer Line4;

    Rigidbody rbKartoffel;
    Rigidbody rbEi;
    Rigidbody rbKarotte;

    Transform parentTransform;
    BoxCollider eimerTrigger;


    bool bEi = false;
    bool bKartoffel = false;
    bool bKarotte = false;

    bool questStarted = false;
    bool questStep1Complete = false;
    bool questStep2Complete = false;
    bool questStep3Complete = false;


    void Start()
    {
        parentTransform = GetComponent<Transform>();

        eimerTrigger = GetComponent<BoxCollider>();

        

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

        if (collisionCheck.stepComplete == true && questStep3Complete == false)
        {
            QuestStep3();
            questStep3Complete = true;
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.gameObject == Kartoffel)
        {
            bKartoffel = true;
            Kartoffel.transform.SetParent(parentTransform);
            rbKartoffel.isKinematic = true;
        }
        if (other.transform.gameObject == Ei)
        {
            bEi = true;
            Ei.transform.SetParent(parentTransform);
            rbEi.isKinematic = true;
        }

        if (other.transform.gameObject == Karotte)
        {
            bKarotte = true;
            Karotte.transform.SetParent(parentTransform);
            rbKarotte.isKinematic = true;
        }
    }

    public void QuestStart()
    {
        if(questStarted == false)
        {
            Line1.enabled = true;
            Line2.enabled = true;
            objectAudioPlayer.PlayQuestStart();
            questStarted = true;
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

    public void KitchenTrigger()
    {
        eimerTrigger.enabled = false;
        Kartoffel.transform.SetParent(null);
        Karotte.transform.SetParent(null);
        Ei.transform.SetParent(null);
        rbKartoffel.isKinematic = false;
        rbKarotte.isKinematic = false;
        rbEi.isKinematic = false;
    }

    void QuestStep3()
    {   
        objectAudioPlayer.PlayQuestStep2();
        Line4.enabled = false;
        for (int i = 0; i < spawnArray.Length; i++)
        {
            spawnArray[i].SetActive(true);
        }
        Destroy(gameObject);
    }
}
