using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AbilityEXP : MonoBehaviour
{
    public EXPSystem playerEXP;
    public int neededXP;
    public Image abilityIcon;
    public bool hasRequiredEXP = false;
    void Start()
    {
        playerEXP = FindAnyObjectByType<EXPSystem>();
        abilityIcon = GetComponent<Image>();
    }

    
    void Update()
    {
        if (playerEXP.exp >= neededXP && hasRequiredEXP == false)
        {
            Color currentColor = abilityIcon.color;
            abilityIcon.color = new Color(currentColor.r, currentColor.g, currentColor.b, 255);
            /*0.3137/80 is the dull form*/
            hasRequiredEXP = true;
        }
    }

}
