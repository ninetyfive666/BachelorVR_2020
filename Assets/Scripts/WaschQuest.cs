using System.Collections;
using System.Collections.Generic;
using Pixelplacement;
using UnityEngine;

public class WaschQuest : MonoBehaviour
{
    [Header("AudioPlayer")]
    public ObjectAudioPlayer objectAudioPlayer;

    [Header("Water")]
    public GameObject Water;
    public GameObject clothPlane;
    Renderer waterRenderer;

    [Header("Wäscheleine")]
    public GameObject Rope;
    public GameObject Smoke;

    [Header("DirtyWaterColor")]
    public Color32 dirty = new Color32(152, 149, 147, 180);

    [Header("Leitsystem")]
    public LineRenderer Line1;
    public LineRenderer Line2;

    Outline clothOutline;


    bool waterCollisionDetected = false;
    bool questStep1Completed = false;
    void Start()
    {
        waterRenderer = Water.GetComponent<Renderer>();
        clothOutline = clothPlane.GetComponent<Outline>();
    }

    // Update is called once per frame
    void Update()
    {
        if(waterCollisionDetected == true && questStep1Completed == false)
        {
            ChangeWaterColor();
            questStep1Completed = true;
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.gameObject == Water)
        {
            waterCollisionDetected = true;
        }
    }

    public void WashingQuestStart()
    {
        objectAudioPlayer.PlayWhashingQuestStart();
        Line1.enabled = true;
        clothOutline.OutlineWidth = 10;

    }

    void ChangeWaterColor()
    {
        Tween.ShaderColor(waterRenderer.material, ("_DeepWaterColor"), dirty, 1, 0f);
        Tween.ShaderColor(waterRenderer.material, ("_ShallowWaterColor"), dirty, 1, 0f);
        objectAudioPlayer.PlayWhashingQuestStep1();
        Line1.enabled = false;
        Line2.enabled = true;
    }

    public void FactorySmoke()
    {
        Smoke.SetActive(true);
        objectAudioPlayer.PlayWhashingQuestStep2();
        Line2.enabled = false;
    }

}
