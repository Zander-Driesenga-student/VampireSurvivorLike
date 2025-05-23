using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(EXPSystem))]
public class AbilityActivator : MonoBehaviour
{
    public List<Abilities> abilities = new List<Abilities>();
    public EXPSystem exp;
    void Start()
    {
        exp = GetComponent<EXPSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1) && abilities[0] && exp.exp >= 200)
        {
            abilities[0].ActivateAbility();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) && abilities[1] && exp.exp >= 800)
        {
            abilities[1].ActivateAbility();
        }
        if (Input.GetKeyDown(KeyCode.Alpha3) && abilities[2] && exp.exp >= 1500)
        {
            abilities[2].ActivateAbility();
        }
        if (Input.GetKeyDown(KeyCode.Alpha4) && abilities[3] && exp.exp >= 2100)
        {
            abilities[3].ActivateAbility();
        }
        else return;
    }
}
