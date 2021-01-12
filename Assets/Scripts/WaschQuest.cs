using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaschQuest : MonoBehaviour
{
    [Header("AudioPlayer")]
    public ObjectAudioPlayer objectAudioPlayer;


    [Header("Interactable")]
    public GameObject Cloth;

    [Header("DirtyWaterColor")]
    public Color32 dirty = new Color32(152, 149, 147, 180);

    [Header("Leitsystem")]
    public LineRenderer Line1;
    public LineRenderer Line2;

    Renderer waterRenderer;

    bool collisionDetected = false;
    bool questStep1Completed = false;
    void Start()
    {
        waterRenderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(collisionDetected == true && questStep1Completed == false)
        {
            ChangeWaterColor();
            questStep1Completed = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.gameObject == Cloth)
        {
            collisionDetected = true;
        }
    }

    public void WashingQuestStart()
    {
        objectAudioPlayer.PlayWhashingQ1();
        Line1.enabled = true;
    }

    void ChangeWaterColor()
    {
        waterRenderer.material.SetColor("_BaseColor", dirty);
    }

}
