using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AOEAbility : MonoBehaviour
{
    public Crosshair mousePosition;
    public GameObject AOEAttack;
    public float duration = 10;
    public int damage = 1;

    private void Awake()
    {

    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        duration -= Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, mousePosition.transform.position, 100f);
        Debug.Log("there is mousePosition" + transform.position.ToString());
    }
}
