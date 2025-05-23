using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kills : MonoBehaviour
{
    [SerializeField] private Text displayKills;
    public int kills = 0;

    private void Awake()
    {
        displayKills = GetComponent<Text>();

    }
    private void Update()
    {
        displayKills.text = kills.ToString();
    }
    public static void TryGetKill()
    {
        
    }
    public void AddKill()
    {
        kills++;
    }
}
