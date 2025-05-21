using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Abilities : MonoBehaviour
{
    public UnityEvent ability = new UnityEvent();
    public float startCooldown = 5;
    public float cooldown = 5;
    public bool active = true; 
    
    // Update is called once per frame
    void Update()
    {
        cooldown -= Time.deltaTime;
        if (cooldown <= 0 )
        {
            active = true;
            cooldown = startCooldown;
        }
    }

    public void ActivateAbility()
    {
        if (active == true)
        {
            ability.Invoke();
            active = false;
        }
    }
}
