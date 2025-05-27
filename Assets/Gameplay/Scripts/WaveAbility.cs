using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveAbility : MonoBehaviour
{
    public GameObject wavePrefab;

    public void FireWave()
    {
        Instantiate(wavePrefab, transform.position, LookAtCrosshair.rotation);
    }
    
    
}
