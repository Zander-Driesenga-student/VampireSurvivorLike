using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AOEAttack : MonoBehaviour
{
    public float duration = 10f;
    public int damage = 1;
    public float startDamageTimer = .5f;
    public float damageTimer = .5f;
    void Start()
    {
        
    }

    
    void Update()
    {
        duration =- Time.deltaTime;
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy") )
        {
            Health.TryDamage(other.gameObject, damage);
        }
    }
}
