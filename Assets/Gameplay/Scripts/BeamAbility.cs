using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamAbility : MonoBehaviour
{
    public Transform beamLocation;
    public GameObject beamReference;
    public Vector3 beamPosition;
    public GameObject beam;

    void Start()
    {
        beamReference = GameObject.FindWithTag("Wand");

    }

    
    void Update()
    {
        beamLocation = beamReference.transform;
        beamPosition = beamReference.transform.position;
    }
    
    public void SpawnBeam()
    {
        if (!beamLocation) return;
        else
        {
            Instantiate(beam, beamPosition, LookAtCrosshair.rotation, beamLocation);
        }
    }
}
