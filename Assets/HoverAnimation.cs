using System.Collections;
using Pixelplacement;
using System.Collections.Generic;
using UnityEngine;

public class HoverAnimation : MonoBehaviour
{
    [Range(0f, 1f)]
    public float duration = .25f;

    public GameObject AnimGoal;

    public Color32 white = new Color32(255, 255, 255, 255);
    public Color32 transparent = new Color32(255, 255, 255, 0);

    MeshRenderer rend;
    Transform origin;
    Transform goal;

    Vector3 originPosition;
    void Start()
    {
        rend = GetComponent<MeshRenderer>();
        rend.material.SetColor("_BaseColor", transparent);

        origin = GetComponent<Transform>();
        goal = AnimGoal.GetComponent<Transform>();
        originPosition = origin.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HoverEnter()
    {
        Tween.Position(origin, origin.position, goal.position, duration, 0, Tween.EaseOut);
        Tween.ShaderColor(rend.material, ("_BaseColor"), transparent, white, duration, 0, Tween.EaseOut);
    }

    public void HoverExit()
    {
        Tween.Position(origin, origin.position, originPosition, duration, 0, Tween.EaseOut);
        Tween.ShaderColor(rend.material, ("_BaseColor"), white, transparent, duration, 0, Tween.EaseOut);
    }
}
