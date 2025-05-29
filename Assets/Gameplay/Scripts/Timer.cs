using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timer;
    public Text timerText;
    public int minutes;
    public int seconds;
    
    public void Update()
    {
        timer += Time.deltaTime;
        minutes = Mathf.FloorToInt(timer / 60f);
        seconds = Mathf .FloorToInt(timer - minutes * 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    
}
