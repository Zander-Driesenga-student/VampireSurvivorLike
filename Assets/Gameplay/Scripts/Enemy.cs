using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private PlayerMovment player;
    public int damage = 1;
    private float damageTimer = 1f;
    public float startDamageTimer = 1f;
    void Start()
    {
        player = FindAnyObjectByType<PlayerMovment>();
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.gameObject.transform.position, 1f * Time.deltaTime);
        
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        damageTimer -= Time.deltaTime;
        if (other.gameObject.CompareTag("Player") && damageTimer <= 0f)
        {
            Health.TryDamage(other.gameObject, damage);
            damageTimer = startDamageTimer;
        }
    }
}
