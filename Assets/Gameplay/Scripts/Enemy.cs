using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public PlayerMovment player;
    public int damage = 1;
    void Start()
    {
        player = FindAnyObjectByType<PlayerMovment>();
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.gameObject.transform.position, 1f * Time.deltaTime);
    }
}
