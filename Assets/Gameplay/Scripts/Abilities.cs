using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Abilities : MonoBehaviour
{
    public UnityEvent ability = new UnityEvent();
    public int startCooldown = 5;
    public bool active = true; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivateAbility()
    {
        if (active == true)
        {
            print("jeff");
            ability.Invoke();
        }
    }
}
