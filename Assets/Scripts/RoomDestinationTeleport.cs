using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomDestinationTeleport : MonoBehaviour
{
    public GameObject XRRig;
    public GameObject DestinationKeller;
    public GameObject DestinationWaschküche;
    public GameObject DestinationSchlafzimmer;
    public GameObject DestinationKüche;
    public GameObject DestinationGarten;

    public void TeleportKeller()
    {
        XRRig.transform.position = DestinationKeller.transform.position;
    }

    public void TeleportWaschküche()
    {
        XRRig.transform.position = DestinationWaschküche.transform.position;
    }

    public void TeleportKüche()
    {
        XRRig.transform.position = DestinationKüche.transform.position;
    }

    public void TeleportGarten()
    {
        XRRig.transform.position = DestinationGarten.transform.position;
    }

    public void TeleportSchlafzimmer()
    {
        XRRig.transform.position = DestinationSchlafzimmer.transform.position;
    }

}
