using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialChanger : MonoBehaviour
{


    public Material newMaterial;
    Material originalMaterial;
    
    public void Start()
    {
        originalMaterial = GetComponent<Renderer>().material;
    }

    public void SetOutline()
    {
        GetComponent<Renderer>().material = newMaterial;
    }

    // Update is called once per frame
    public void RemoveOutline()
    {
         GetComponent<Renderer>().material = originalMaterial;
    }
}
