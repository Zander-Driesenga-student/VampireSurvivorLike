using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireProjectile : MonoBehaviour
{
    public GameObject prefab;
    public float startFireRate = 20.0f;
    private float fireRate = 0.0f;
    public bool automatic = false;

    void Update()
    {
        if (automatic == true)
        {
            if (Input.GetMouseButton(0))
            {
                if (fireRate > 0)
                {
                    fireRate--;
                    return;
                }
                Instantiate(prefab, transform.position, transform.rotation);
                fireRate = startFireRate;
            }
        }
        else
        {
            if (Input.GetMouseButtonDown(0))
            {
                Instantiate(prefab, transform.position, transform.rotation);
            }
        }
        
    }
}
