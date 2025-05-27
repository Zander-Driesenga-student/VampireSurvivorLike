using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Abilities : MonoBehaviour
{
    public UnityEvent ability = new UnityEvent();
    public Image abilityIcon;
    public Image dullImage;
    public float startCooldown = 5;
    public float cooldown = 5;
    public bool active = true; 
    
    // Update is called once per frame
    void Update()
    {
        if (active == false)
        {
            cooldown -= Time.deltaTime;
            
            if (cooldown <= 0)
            {
                active = true;
                OffCooldown();
                cooldown = startCooldown;
            }
        }
    }

    public void ActivateAbility()
    {
        if (active == true)
        {
            ability.Invoke();
            active = false;
            OnCooldown();
        }
    }
    
    public void OnCooldown()
    {
        dullImage.enabled = true;
        abilityIcon.enabled = false;
    }

    public void OffCooldown()
    {
        dullImage.enabled = false;
        abilityIcon.enabled = true;
    }

}
