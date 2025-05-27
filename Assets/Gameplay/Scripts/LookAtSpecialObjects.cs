using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtSpecialObjects : MonoBehaviour
{
    public float rot_z;
    public static Quaternion rotation;
    public GameObject specialObject;

    void Update()
    {
        Vector3 diff = specialObject.transform.position - transform.position;
        diff.Normalize();
        rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rot_z - 90);
        rotation = Quaternion.Euler(0f, 0f, rot_z - 90);
    }
}
