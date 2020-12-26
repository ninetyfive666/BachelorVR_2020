using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialColorFader : MonoBehaviour
{
    public Color Highlight = Color.cyan;
    public Color Outline = Color.white;
    public Color Transparent = Color.white;


    public void EnableHighlight()
    {
          var rend = gameObject.GetComponent<Renderer>();
          rend.material.SetColor("_EmissiveColor", Highlight);
    }

    public void DisableHighlight()
    {
        var rend = gameObject.GetComponent<Renderer>();
        rend.material.SetColor("_EmissiveColor", Color.white);
    }

    public void EnableOutline()
    {
        var rend = gameObject.GetComponent<Renderer>();
        rend.material.SetColor("_EmissiveColor", Outline);
    }

    public void DisableOutline()
    {
        var rend = gameObject.GetComponent<Renderer>();
        rend.material.SetColor("_EmissiveColor", Transparent);
    }
}
