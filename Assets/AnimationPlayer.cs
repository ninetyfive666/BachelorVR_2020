using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationPlayer : MonoBehaviour
{

    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void HoverEnter()
    {
        anim.Play("_Active");
    }

    public void HoverExit()
    {
        anim.Play("_NonActive");
    }
}
