using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 10.0f;
    public float targetTime = 10.0f;
    void Update()
    {
        transform.position += transform.up * speed * Time.deltaTime;
        targetTime -= Time.deltaTime;

        if (targetTime <= 0.0f)
        {
            Destroy(gameObject);
        }
    }
}
