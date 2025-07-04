using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedAbility : MonoBehaviour
{
    public PlayerMovment player;
    public float duration;
    public float startDuration;
    public bool ready = true;
    public float playerSpeed;
    public float speedMulti;
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
                duration = startDuration;
                ready = true;
            }
        }
    }
    public void MakePlayerFast()
    {
        player._moveSpeed *= speedMulti;
        ready = false;
    }

}
