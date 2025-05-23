using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private PlayerMovment player;
    public int damage = 1;
    public int damage1 = 1;
    public static int damage2 = 1;
    private float damageTimer = 1f;
    public float startDamageTimer = 1f;
    public static int startHealth1;
    public int startHealth;
    public Health health;
    public int currentHealth;
    public int currentHealth2;
    public static int currentHealth1;
    public EXPSystem expSystem;
    public bool killed = false;

    private void Awake()
    {
        startHealth1 = startHealth;
        health = GetComponent<Health>();
        currentHealth2 = health.currentHealth;
        expSystem = FindAnyObjectByType<EXPSystem>();
        damage1 = damage;
    }

    void Start()
    {
        player = FindAnyObjectByType<PlayerMovment>();
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.gameObject.transform.position, 1f * Time.deltaTime);
        currentHealth = health.currentHealth;
        currentHealth1 = currentHealth;
        damage1 = damage2;
        if (currentHealth <= 0)
        {
            killed = true;
            Destroy(gameObject);
        }
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
    private void OnDestroy()
    {
        if (killed == true)
        {
            expSystem.exp += currentHealth2;
            Kills.TryGetKill();
        }
        if (expSystem.exp >= 2100)
        {
            Health.TryHeal(player.gameObject, currentHealth2);
        }
        else
        {
            return;

        }
    }
}
