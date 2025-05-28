using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class QuitWatcher : MonoBehaviour
{
    public UnityEvent onEsc = new UnityEvent();

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            onEsc.Invoke();
        }
    }
}
