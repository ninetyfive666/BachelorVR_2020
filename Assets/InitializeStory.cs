using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializeStory : MonoBehaviour
{
    public RoomDestinationTeleport roomDestinationTeleport;

    Animation anim;

    AudioSource audioSource;

    float introDuration;

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animation>();
        audioSource = gameObject.GetComponent<AudioSource>();
        introDuration = audioSource.clip.length;
    }

    // Update is called once per frame

    public void intitStory()
    {
        StartCoroutine(ExampleCoroutine());

    }

    IEnumerator ExampleCoroutine()
    {
        anim.Play();
        audioSource.Play();
        yield return new WaitForSeconds(introDuration);
        roomDestinationTeleport.TeleportKüche();
    }
}