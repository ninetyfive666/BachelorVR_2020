using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetTransform : MonoBehaviour
{
    public GameObject origin;
    public GameObject grabable;

    public void ResetTransform()
    {
        grabable.transform.position = origin.transform.position;
        grabable.transform.rotation = origin.transform.rotation;
    }
}
