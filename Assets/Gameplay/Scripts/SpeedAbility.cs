using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedAbility : MonoBehaviour
{
    public PlayerMovment player;
    public float duration = 5f;
    public bool ready = true;
    public float playerSpeed;
    void Start()
    {
        player = FindAnyObjectByType<PlayerMovment>();
        playerSpeed = player._moveSpeed;
    }

    void Update()
    {
        if (ready)
        {

        }
        else
        {
            duration -= Time.deltaTime;
            if (duration <= 0)
            {
                player._moveSpeed = playerSpeed;
                duration = 5f;
                ready = true;
            }
        }
    }
    public void MakePlayerFast()
    {
        player._moveSpeed *= 2f;
        ready = false;
    }

}
