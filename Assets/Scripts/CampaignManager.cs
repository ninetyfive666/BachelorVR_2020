using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CampaignManager : MonoBehaviour
{
    [Header("Level 1 Objects")]
    public List<GameObject> level1Objects = new List<GameObject>();
    public List<Material> level1Materials;

    [Header("Blank White Material")]
    public Material blankWhite;

    public void Start()
    {
        // Adds a Material slot for each Gameobject
        level1Materials.AddRange(new Material[level1Objects.Count]);
        Debug.Log(level1Materials.Count);

        // For every level1Object execute the following function 1 time and add 1 to i
        for (int i = 0; i < level1Objects.Count; i++)
        {
            level1Materials[i] = level1Objects[i].GetComponent<Renderer>().material;
            Debug.Log("ich hab ein Material dazugepackt");
        }
    }

    public void SetWhite()
    {
        // For every level1Object execute the following function 1 time and add 1 to i
        for (int i = 0; i < level1Objects.Count; i++)
        {
            level1Objects[i].GetComponent<Renderer>().material = blankWhite;
            Debug.Log("ich hab ein Objekt weiß eingefärbt");
        }

    }
    
    public void Level1()
    {

        // For every level1Object execute the following function 1 time and add 1 to i
        for (int i = 0; i <= level1Objects.Count; i++)
        {
            level1Objects[i].GetComponent<Renderer>().material = level1Materials[i];
            Debug.Log("ich hab ein Objekt zurückgefärbt");
        }
    }


}
