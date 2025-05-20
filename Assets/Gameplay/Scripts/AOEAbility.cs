using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;

public class AOEAbility : MonoBehaviour
{
    public Crosshair mousePosition;
    public GameObject AOEAttack;
    public float duration = 10;
    public Vector3 currentPosition;

    private void Awake()
    {
        mousePosition = FindAnyObjectByType<Crosshair>();
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        duration -= Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, mousePosition.transform.position, 100f);
    }
    public void SpawnAttack()
    {
        Instantiate(AOEAttack, Crosshair.mousePosition, Quaternion.identity);
    }
}
