using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityActivator : MonoBehaviour
{
    public List<Abilities> abilities = new List<Abilities>();
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1) && abilities[0] != null)
        {
            abilities[0].ActivateAbility();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) && abilities[1] != null)
        {
            abilities[1].ActivateAbility();
        }
        if (Input.GetKeyDown(KeyCode.Alpha3) && abilities[2] != null)
        {
            abilities[2].ActivateAbility();
        }
        if (Input.GetKeyDown(KeyCode.Alpha4) && abilities[3] != null)
        {
            abilities[3].ActivateAbility();
        }
        else return;
    }
}
