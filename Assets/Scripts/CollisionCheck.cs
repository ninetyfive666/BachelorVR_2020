using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCheck : MonoBehaviour
{
    public GameObject object1;
    public GameObject object2;
    public GameObject object3;

    bool object1Detected = false;
    bool object2Detected = false;
    bool object3Detected = false;

    public bool stepComplete = false;


    void Start()
    {

    }
    void Update()
    {
        if(object1Detected == true && object2Detected == true && object3Detected == true)
        {
            stepComplete = true;
        }
    }

    public void OnCollisionEnter(Collision Collider)
    {
        if (Collider.transform.gameObject == object1)
        {
            object1Detected = true;
            Destroy(object1);
        }

        if (Collider.transform.gameObject == object2)
        {
            object2Detected = true;
            Destroy(object2);
        }

        if (Collider.transform.gameObject == object3)
        {
            object3Detected = true;
            Destroy(object3);
        }

    }
}
