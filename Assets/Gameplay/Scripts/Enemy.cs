using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public PlayerMovment player;
    // Start is called before the first frame update
    void Start()
    {
        player = FindAnyObjectByType<PlayerMovment>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.gameObject.transform.position, 1f * Time.deltaTime);
    }
}
