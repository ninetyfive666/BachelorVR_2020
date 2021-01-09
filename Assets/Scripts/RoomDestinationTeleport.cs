using Pixelplacement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class RoomDestinationTeleport : MonoBehaviour
{
    public GameObject XRRig;
    public Volume volume = null;

    public GameObject DestinationKeller;
    public GameObject DestinationWaschküche;
    public GameObject DestinationSchlafzimmer;
    public GameObject DestinationKüche;
    public GameObject DestinationGarten;

    [Range(0f,1f)]
    public float intensity = 0.75f;
    [Range(0f, 1f)]
    public float duration = 0.5f;

    private Vignette vignette = null;

    public void FadeIn()
    {
        Tween.Value(0, intensity, ApplyValue, duration, 0, Tween.EaseOut);
    }

    public void FadeOut()
    {
        Tween.Value(intensity, 0, ApplyValue, duration, duration, Tween.EaseOut);
    }

    public void Awake()
    {
        if (volume.profile.TryGet(out Vignette vignette))
            this.vignette = vignette;
    }

    public void TeleportKeller()
    {
        FadeIn();
        Tween.Position(XRRig.transform, XRRig.transform.position, DestinationKeller.transform.position, 0.01f, duration);
        FadeOut();
    }

    public void TeleportWaschküche()
    {
        FadeIn();
        Tween.Position(XRRig.transform, XRRig.transform.position, DestinationWaschküche.transform.position, 0.01f, duration);
        FadeOut();
    }

    public void TeleportKüche()
    {
        FadeIn();
        Tween.Position(XRRig.transform, XRRig.transform.position, DestinationKüche.transform.position, 0.01f, duration);
        FadeOut();
    }

    public void TeleportGarten()
    {
        FadeIn();
        Tween.Position(XRRig.transform, XRRig.transform.position, DestinationGarten.transform.position, 0.01f, duration);
        FadeOut();
    }

    public void TeleportSchlafzimmer()
    {
        FadeIn();
        Tween.Position(XRRig.transform, XRRig.transform.position, DestinationSchlafzimmer.transform.position, 0.01f, duration);
        FadeOut();
    }

    private void ApplyValue(float value)
    {
        vignette.intensity.Override(value);
    }

}
