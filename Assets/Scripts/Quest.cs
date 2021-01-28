using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest : MonoBehaviour
{
    [Header("AudioPlayer")]
    public ObjectAudioPlayer objectAudioPlayer;

    [Header("Topf Collectable Goal")]
    public CollisionCheck collisionCheck;

    [Header("Collectables")]
    public GameObject Kartoffel;
    public GameObject Petersilie;
    public GameObject Karotte;

    [Header("Spawn")]
    public GameObject Prop;
    public GameObject Kartoffelsuppe;


    [Header("Leitsystem")]
    public LineRenderer Line1;
    public LineRenderer Line2;
    public LineRenderer Line3;
    public LineRenderer Line4;

    Rigidbody rbKartoffel;
    Rigidbody rbEi;
    Rigidbody rbKarotte;

    public GameObject Kueche;

    Transform parentTransform;
    BoxCollider eimerTrigger;

    MeshRenderer rend;

    bool bEi = false;
    bool bKartoffel = false;
    bool bKarotte = false;

    bool questStarted = false;
    bool questStep1Complete = false;
    public bool questStep2Complete = false;
    bool questStep3Complete = false;


    void Start()
    {

        parentTransform = GetComponent<Transform>();
        eimerTrigger = GetComponent<BoxCollider>();

        rend = GetComponent<MeshRenderer>();
        rend.enabled = false;

        rbKartoffel = Kartoffel.GetComponent<Rigidbody>();
        rbEi = Petersilie.GetComponent<Rigidbody>();
        rbKarotte = Karotte.GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (bKartoffel == true && questStep1Complete == false)
        {
            QuestStep1();
            questStep1Complete = true;
        }

        if (bKarotte == true && bEi == true && questStep2Complete == false)
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
        if (other.transform.gameObject == Petersilie)
        {
            bEi = true;
            Petersilie.transform.SetParent(parentTransform);
            rbEi.isKinematic = true;
        }

        if (other.transform.gameObject == Karotte)
        {
            bKarotte = true;
            Karotte.transform.SetParent(parentTransform);
            rbKarotte.isKinematic = true;
        }
    }

    // Quest wird gestartet
    public void QuestStart()
    {
        if(questStarted == false)
        {
            Line1.enabled = true;
            Line2.enabled = true;
            objectAudioPlayer.PlayQuestStart();
            questStarted = true;
            rend.enabled = true;
        }

    }

    // Kartoffel im Eimer
    void QuestStep1()
    {
        objectAudioPlayer.PlayQuestStep1();
        Line1.enabled = false;
        Line2.enabled = false;
        Line3.enabled = true;
    }

    // Petersilie und Karotte im Eimer
    void QuestStep2()
    {
        objectAudioPlayer.PlayQuestStep2();
        Line3.enabled = false;
        Line4.enabled = true;
        Prop.SetActive(true);
        Kueche.gameObject.SetActive(true);
    }

    // Wieder zurück in der Küche
    public void KitchenTrigger()
    {
        eimerTrigger.enabled = false;
        Kartoffel.transform.SetParent(null);
        Karotte.transform.SetParent(null);
        Petersilie.transform.SetParent(null);
        rbKartoffel.isKinematic = false;
        rbKarotte.isKinematic = false;
        rbEi.isKinematic = false;

    }

    //Alle Zutaten sind im Topf
    void QuestStep3()
    {   
        objectAudioPlayer.PlayQuestStep3();
        Kartoffelsuppe.SetActive(true);
        Line4.enabled = false;
        rend.enabled = false;
    }
}
