using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerActivation : MonoBehaviour
{
    public Quest Quest;

    bool triggerHasBeenActivated;
    bool triggerRecognized;

    private void Update()
    {
        if (triggerRecognized == true && triggerHasBeenActivated == false)
        {
            Quest.KitchenTrigger(); 
            triggerHasBeenActivated = true;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        triggerRecognized = true;
    }
}
