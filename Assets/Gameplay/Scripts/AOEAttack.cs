using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AOEAttack : MonoBehaviour
{
    public float duration = 10f;
    public int damage = 1;
    public float startDamageTimer = .5f;
    private float damageTimer = .5f;
    void Start()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, 0);
    }

    
    void Update()
    {
        duration -= Time.deltaTime;
        damageTimer -= Time.deltaTime;
        if (damageTimer <= 0)
        {
            damageTimer = startDamageTimer;
        }
        if (duration <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        print("jeff");
        if (other.gameObject.CompareTag("Enemy") && damageTimer > 0f)
        {
            print("jeff2");
            Health.TryDamage(other.gameObject, damage);
        }
    }
}
